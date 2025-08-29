using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using NativeWebSocket;
using Newtonsoft.Json;

public class WebSocketVoiceClient : MonoBehaviour
{
    [Header("AI 서버 연결 설정")]
    public string audioWebSocketUrl = "ws://221.163.19.142:58026/ws/audio";
    public string triggerWebSocketUrl = "ws://221.163.19.142:58026/ws/trigger";

    [Header("호스트 전용 설정")]
    [Tooltip("호스트만 체크하세요. 키워드 데이터를 받을 클라이언트만 체크")]
    public bool isHost = false;

    private WebSocket audioSocket;
    private WebSocket triggerSocket;

    public bool IsTriggerConnected => triggerSocket != null && triggerSocket.State == WebSocketState.Open;
    public bool IsAudioConnected => audioSocket != null && audioSocket.State == WebSocketState.Open;

    void Start()
    {
        ConnectWebSockets();
    }

    async void ConnectWebSockets()
    {
        audioSocket = new WebSocket(audioWebSocketUrl);
        triggerSocket = new WebSocket(triggerWebSocketUrl);

        audioSocket.OnOpen += () => Debug.Log("[Audio WebSocket] 연결 성공");
        audioSocket.OnError += (e) => Debug.LogError("[Audio WebSocket Error] " + e);
        audioSocket.OnClose += (e) => Debug.LogWarning("[Audio WebSocket] 닫힘: " + e);

        audioSocket.OnMessage += (bytes) =>
        {
            string message = Encoding.UTF8.GetString(bytes);
            Debug.Log("[AI TEXT 응답] " + message);
        };

        triggerSocket.OnOpen += () => Debug.Log("[Trigger WebSocket] 연결 성공");
        triggerSocket.OnError += (e) => Debug.LogError("[Trigger WebSocket Error] " + e);
        triggerSocket.OnClose += (e) => Debug.LogWarning("[Trigger WebSocket] 닫힘: " + e);

        // 호스트만 키워드 데이터 수신
        triggerSocket.OnMessage += (bytes) =>
        {
            // 호스트가 아니면 키워드 데이터 무시
            if (!isHost) return;

            try
            {
                string jsonString = Encoding.UTF8.GetString(bytes);
                Debug.Log("[Trigger WebSocket] 수신 데이터: " + jsonString);

                // JSON이 아닐 경우 무시
                if (!jsonString.TrimStart().StartsWith("{"))
                {
                    Debug.LogWarning("[Trigger WebSocket] JSON 형식 아님 → 무시됨");
                    return;
                }

                var parsed = JsonConvert.DeserializeObject<EmotionKeywordData>(jsonString);

                if (parsed?.keywords != null && parsed.emotions != null)
                { 
                    // 각 키워드 하나씩 로그
                    foreach (var kw in parsed.keywords)
                        Debug.Log($"[Parsed ▶ Keyword] {kw}");

                    // 각 감정 하나씩 로그
                    foreach (var em in parsed.emotions)
                        Debug.Log($"[Parsed ▶ Emotion] {em}");
                    
                    // Host가 AI 데이터를 받으면 AIResponseStore에 저장
                    AIResponseStore.Instance?.UpdateData(parsed.keywords, parsed.emotions); 
                    Debug.Log(
                        $"[AI 요약]\n" + 
                        $"▶ Keywords: {string.Join(", ", parsed.keywords)}\n" + 
                        $"▶ Emotions: {string.Join(", ", parsed.emotions)}"
                        );
                    
                    // Host가 받은 AI 데이터를 모든 클라이언트에게 전송
                    var performanceController = FindObjectOfType<PerformanceController>();
                    if (performanceController != null)
                    {
                        string[] keywordArray = parsed.keywords.ToArray();
                        string[] emotionArray = parsed.emotions.ToArray();
                        performanceController.SendAIDataToAllClientsRPC(keywordArray, emotionArray);
                        Debug.Log("[Host] AI 데이터를 모든 클라이언트에게 전송 완료");
                    }
                }
                else
                {
                    Debug.LogWarning("[Trigger WebSocket] 응답은 JSON이지만 요약 정보 없음.");
                }
            }
            catch (Exception ex)
            {
                Debug.LogError("[Trigger WebSocket] JSON 파싱 오류: " + ex.Message);
            }
        };

        var audioTask = audioSocket.Connect();
        var triggerTask = triggerSocket.Connect();

        await System.Threading.Tasks.Task.WhenAll(audioTask, triggerTask);

        Debug.Log("[Audio WebSocket] Connect() 완료");
        Debug.Log("[Trigger WebSocket] Connect() 완료");
    }

    // 클라이언트가 직접 WAV 데이터를 AI 서버로 전송
    public void TrySendWav(byte[] wavData)
    {
        StartCoroutine(WaitAndSendWav(wavData));
    }

    private IEnumerator WaitAndSendWav(byte[] wavData)
    {
        int maxTries = 20;
        int attempts = 0;

        while (audioSocket.State != WebSocketState.Open && attempts < maxTries)
        {
            Debug.Log("[Audio WebSocket] 연결 대기 중...");
            yield return new WaitForSeconds(0.3f);
            attempts++;
        }

        if (audioSocket.State == WebSocketState.Open)
        {
            Debug.Log("[Audio WebSocket] 최종 연결됨. 전송 시작");
            audioSocket.Send(wavData);
        }
        else
        {
            Debug.LogWarning("[Audio WebSocket] 연결 실패. 전송 포기");
        }
    }

    // 호스트만 gauge_full 신호 전송
    public void SendGaugeSignal()
    {
        if (!isHost)
        {
            Debug.LogWarning("[Trigger WebSocket] 호스트가 아니므로 gauge_full 전송 불가");
            return;
        }

        if (!IsTriggerConnected)
        {
            Debug.LogWarning("[Trigger WebSocket] 아직 연결되지 않았습니다. 전송 중단");
            return;
        }

        triggerSocket.SendText("gauge_full");
        Debug.Log("[Trigger WebSocket] gauge_full 전송 완료");
    }

    void Update()
    {
#if !UNITY_WEBGL || UNITY_EDITOR
        audioSocket?.DispatchMessageQueue();
        triggerSocket?.DispatchMessageQueue();
#endif
    }

    private async void OnApplicationQuit()
    {
        await audioSocket.Close();
        await triggerSocket.Close();
    }
}
using UnityEngine;

public class DisablePrepareObject : MonoBehaviour
{
    [Header("공연 시작 시 비활성화할 오브젝트")]
    [SerializeField] private GameObject mirror;
    [SerializeField] private GameObject chatCanvas;

    [Header("선택: 지연 비활성화(초)")]
    [SerializeField] private float delay = 0f;

    void OnEnable()
    {
        // 성능/안정성: 중복 구독 방지 위해 한 번만 연결
        PerformanceController.OnShowStarted -= HandleShowStarted;
        PerformanceController.OnShowStarted += HandleShowStarted;
    }

    void OnDisable()
    {
        PerformanceController.OnShowStarted -= HandleShowStarted;
    }

    private void HandleShowStarted()
    {
        if (delay <= 0f)
        {
            ApplyDisable();
        }
        else
        {
            // 로컬 지연 후 비활성화 (네트워크 동기화 필요 없음)
            Invoke(nameof(ApplyDisable), delay);
        }
    }

    private void ApplyDisable()
    {
        if (mirror != null && mirror.activeSelf)
            mirror.SetActive(false);

        if (chatCanvas != null && chatCanvas.activeSelf)
            chatCanvas.SetActive(false);
    }
}
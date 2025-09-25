# VStage Win Public - 고급 Unity VR 퍼포먼스 플랫폼

<div align="center">

![Unity](https://img.shields.io/badge/Unity-6000.1.2f1-000000?style=for-the-badge&logo=unity)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp)
![VR](https://img.shields.io/badge/VR-Ready-blue?style=for-the-badge)
![Photon](https://img.shields.io/badge/Photon-Fusion-ff6600?style=for-the-badge)
![Platform](https://img.shields.io/badge/Platform-Windows-blue?style=for-the-badge)

*실시간 네트워킹, 고급 캐릭터 컨트롤, AI 기반 관객 상호작용을 특징으로 하는 전문급 Unity VR 가상 무대 공연 애플리케이션*

</div>

---

## 🚀 개요

VStage Win Public은 몰입형 무대 경험을 제공하는 고급 네트워킹 기능을 갖춘 정교한 Unity 기반 가상현실 공연 플랫폼입니다. 이 애플리케이션은 VR 추적, 실시간 얼굴 애니메이션, AI 기반 관객 반응, 전문급 네트워킹을 결합하여 포괄적인 가상 무대 환경을 구현합니다.

### 주요 기능

#### 🥽 **고급 VR 통합**
- **VRIK (Virtual Reality Inverse Kinematics)** - FinalIK를 사용한 전신 VR 추적
- **멀티플랫폼 VR 지원** - SteamVR, Oculus, HTC Vive 호환
- **자동 보정** - 지속적인 보정 데이터로 스마트 VR 설정
- **지면 제약 시스템** - 현실적인 아바타 위치 및 움직임

#### 🌐 **고성능 네트워킹**
- **Photon Fusion** - 정밀한 동기화를 위한 틱 기반 네트워킹
- **호스트-클라이언트 아키텍처** - 공연 시나리오에 최적화
- **본 수준 동기화** - 실시간 아바타 포즈 공유 (100개 본)
- **공연 타임라인 동기화** - 모든 클라이언트에서 통합된 쇼 타이밍

#### 🎭 **캐릭터 & 애니메이션 시스템**
- **얼굴 추적** - 6채널 얼굴 표정 캡처 및 동기화
- **휴머노이드 아바타 지원** - 709개 이상의 스크립트로 고급 리깅
- **천 시뮬레이션** - 현실적인 천 물리를 위한 MagicaCloth V2 통합
- **애니메이션 타임라인** - 공연용 전문 타임라인 컨트롤

#### 🤖 **AI 기반 상호작용**
- **감정 인식** - 관객 반응을 위한 실시간 채팅 분석
- **동적 이펙트 트리거** - 감정에 기반한 AI 기반 시각 효과
- **음성 처리** - WebSocket 기반 실시간 음성 스트리밍
- **마이크 통합** - 고급 오디오 녹음 및 처리

#### 🎨 **시각 & 오디오 시스템**
- **URP (Universal Render Pipeline)** - VR용 최적화된 렌더링
- **lilToon 셰이더** - 전문급 아니메 스타일 캐릭터 렌더링
- **VFX Graph** - 고급 파티클 시스템 및 시각 효과
- **볼류메트릭 라이팅** - URP 통합 분위기 조명
- **실시간 오디오** - 마이크 녹음을 포함한 공간 오디오

---

## 📁 프로젝트 구조

```
VStage_Win_Public/
├── 📂 Assets/
│   ├── 📂 01_Scenes/              # Unity 씬 (100개 이상 씬)
│   │   ├── Artist_app_final.unity    # 메인 애플리케이션 씬
│   │   ├── Character.unity            # 캐릭터 테스트 씬
│   │   ├── Network.unity              # 네트워킹 테스트 씬
│   │   └── ...                        # 데모 및 테스트 씬
│   │
│   ├── 📂 02_Prefabs/             # 재사용 가능한 게임 오브젝트 (211개 프리팹)
│   │   ├── Characters/                # 아바타 프리팹
│   │   ├── VFX/                      # 시각 효과
│   │   └── UI/                       # 사용자 인터페이스 요소
│   │
│   ├── 📂 03_Scripts/             # C# 스크립트 (709개 스크립트)
│   │   ├── Api/                      # API 통합 & 음성
│   │   ├── Calibration/              # VR 보정 시스템
│   │   ├── Facial/                   # 얼굴 추적
│   │   ├── Photon/                   # 네트워킹 컴포넌트
│   │   ├── UI/                       # 인터페이스 컨트롤러
│   │   └── ...                       # 핵심 시스템
│   │
│   ├── 📂 Art/                    # 시각 자산 (667개 미디어 파일)
│   │   ├── Characters/               # 3D 캐릭터 모델
│   │   ├── Background/               # 무대 환경
│   │   ├── VFX/                      # 시각 효과 자산
│   │   ├── UI asset/                 # 인터페이스 그래픽
│   │   └── Animations/               # 애니메이션 클립
│   │
│   ├── 📂 Audio/                  # 오디오 자산
│   ├── 📂 Plugins/                # 서드파티 플러그인
│   │   ├── RootMotion/FinalIK/       # 고급 IK 시스템
│   │   └── ...                       # 기타 플러그인
│   │
│   ├── 📂 MagicaCloth2/           # 천 시뮬레이션 시스템
│   ├── 📂 Photon/                 # Photon Fusion 네트워킹
│   ├── 📂 XR/                     # VR/XR 통합
│   └── 📂 ThirdParty/             # 외부 자산
│
├── 📂 ProjectSettings/            # Unity 프로젝트 설정
├── 📂 Packages/                   # 패키지 관리자 종속성
└── 📄 README.md                   # 이 파일
```

---

## 🛠 기술 스택

### 핵심 기술
| 기술 | 버전 | 용도 |
|------|------|------|
| **Unity Engine** | 6000.1.2f1 | 핵심 게임 엔진 |
| **C# .NET** | Framework 4.7.1 | 주 스크립팅 언어 |
| **Universal RP** | 17.1.0 | 렌더링 파이프라인 |
| **Input System** | 1.14.0 | 현대적 입력 처리 |

### VR & 추적
| 플러그인 | 용도 |
|----------|------|
| **FinalIK** | 고급 역운동학 |
| **Unity XR Toolkit** | 크로스플랫폼 VR 지원 |
| **SteamVR Plugin** | Valve Index/Vive 지원 |
| **Oculus Integration** | Meta Quest 지원 |
| **HTC Vive OpenXR** | HTC 하드웨어 지원 |

### 네트워킹 & 통신
| 시스템 | 용도 |
|--------|------|
| **Photon Fusion** | 고성능 네트워킹 |
| **WebSocket Client** | 실시간 음성 스트리밍 |
| **Unity Netcode** | 네트워크 오브젝트 관리 |
| **JSON.NET** | 데이터 직렬화 |

### 시각 & 오디오
| 자산 | 용도 |
|------|------|
| **lilToon Shader** | 아니메 스타일 캐릭터 렌더링 |
| **MagicaCloth V2** | 고급 천 시뮬레이션 |
| **VFX Graph** | 파티클 시스템 생성 |
| **Cinemachine** | 동적 카메라 컨트롤 |
| **Timeline System** | 컷신 및 애니메이션 시퀀싱 |

---

## 🎯 핵심 시스템 심층 분석

### 1. VR 추적 시스템
```csharp
// VRIKNetworkPlayer.cs - 네트워크 동기화를 포함한 호스트 VR 추적
[Networked, Capacity(100)] public NetworkArray<Quaternion> BoneRotations
[Networked] public Vector3 RootPosition { get; set; }
[Networked] public Quaternion RootRotation { get; set; }
```
- 100개 이상의 본 동기화를 통한 **전신 추적**
- 지속적인 데이터 저장을 통한 **자동 보정**
- 현실적인 움직임을 위한 **지면 제약** 시스템
- 호스트-클라이언트 아키텍처를 통한 **멀티유저 지원**

### 2. AI 반응 시스템
```csharp
// Api_Reaction.cs - AI 기반 관객 상호작용
private string apiUrl = "http://192.168.0.64:8000/process-form";
public class Result { public bool trigger; public string effect; }
```
- 채팅 입력으로부터 **실시간 감정 분석**
- 감정에 기반한 **동적 효과 트리거링**
- 실시간 통신을 위한 **WebSocket 통합**
- 외부 서비스를 위한 **확장 가능한 API 아키텍처**

### 3. 얼굴 추적
```csharp
// SimpleShinanoFacialTracking.cs - 6채널 얼굴 동기화
[Networked] public float FacialJaw { get; set; }
[Networked] public float FacialSmile { get; set; }
// 완전한 표현 캡처를 위한 4개 채널 추가
```
- **6채널 표정 추적** (턱, 미소, 넓게, O, 슬픔, 혀)
- 모든 클라이언트에서 **실시간 네트워크 동기화**
- 가상 아바타에 최적화된 **아니메 스타일 얼굴 애니메이션**

---

## 🚀 빠른 시작 가이드

### 전제 조건
- **Unity 6000.1.2f1** 이상
- **Windows 10/11** (64비트)
- **VR 헤드셋** (SteamVR 호환)
- **최소 16GB RAM**
- **GTX 1070** 또는 동급 GPU

### 설치 단계

1. **저장소 클론**
   ```bash
   git clone https://github.com/your-repo/vstage-win-public.git
   cd vstage-win-public
   ```

2. **Unity 설정**
   - Unity Hub 열기
   - 디스크에서 프로젝트 추가
   - 필요시 Unity 6000.1.2f1 설치
   - 패키지 해결 대기 (5-10분 소요)

3. **패키지 구성**
   ```json
   // manifest.json의 주요 패키지
   "com.unity.xr.interaction.toolkit": "3.1.2"
   "com.unity.render-pipelines.universal": "17.1.0"
   "com.unity.inputsystem": "1.14.0"
   ```

4. **VR 하드웨어 설정**
   - VR 헤드셋 연결 및 보정
   - SteamVR 실행 확인
   - VR 설정에서 추적 공간 구성

5. **네트워크 구성**
   - Photon 설정에서 Photon 앱 ID 설정
   - 스크립트에서 네트워크 엔드포인트 구성
   - Network 씬으로 연결 테스트

### 첫 실행
1. `Artist_app_final.unity` 씬 열기
2. 프로젝트 설정 > XR 플러그인 관리에서 VR 설정 구성
3. 빌드 후 실행 또는 플레이 모드에서 테스트
4. VR 내 보정 프롬프트 따라하기

---

## 🎮 사용 가이드

### 메인 씬

#### 🎭 **Artist_app_final.unity**
- 라이브 공연용 **주요 애플리케이션 씬**
- 관객 상호작용을 포함한 완전한 VR 통합
- AI 기반 반응 시스템 활성화
- 전문 타임라인 컨트롤

#### 👤 **Character.unity**
- 캐릭터 테스트 및 커스터마이징
- 얼굴 추적 보정
- 아바타 설정 및 리깅 테스트

#### 🌐 **Network.unity**
- 네트워킹 기능 테스트
- 멀티유저 연결 설정
- 성능 최적화 테스트

### 주요 컨트롤

| 동작 | 입력 | 설명 |
|------|------|------|
| **VR 보정** | 트리거 메뉴 | 자동 보정 시퀀스 |
| **이펙트 토글** | 그립 버튼 | VFX 시스템 토글 |
| **음성 녹음** | Y/B 버튼 | 마이크 활성화 |
| **메뉴 탐색** | 터치패드 | UI 상호작용 |

### 공연 기능

#### 타임라인 컨트롤
- 조정된 공연을 위한 **전문 시퀀싱**
- 정밀한 타이밍을 가진 **멀티트랙 애니메이션**
- 네트워크 클라이언트에서 **실시간 동기화**
- 공연 큐에 기반한 **이펙트 트리거링**

#### 관객 상호작용
- AI 감정 인식을 통한 **채팅 처리**
- 관객 감정에 대한 **동적 조명** 반응
- 관중 참여를 위한 **이펙트 트리거**
- **실시간 피드백** 디스플레이 시스템

---

## 🔧 구성

### 네트워크 설정
```csharp
// PhotonSettings에서 구성
public static class NetworkConfig
{
    public const string APP_ID = "YOUR_PHOTON_APP_ID";
    public const string APP_VERSION = "1.0";
    public const int MAX_PLAYERS = 20;
}
```

### VR 구성
```csharp
// PlayerSettings의 VR 설정
defaultScreenWidth: 1024
defaultScreenHeight: 768
virtualRealitySupported: true
stereoRenderingPath: SinglePassInstanced
```

### 성능 최적화
- **렌더 파이프라인**: VR 최적화를 위한 Universal RP
- **텍스처 스트리밍**: 대용량 자산 관리를 위해 활성화
- **물리**: VR 상호작용에 최적화
- **오디오**: 거리 감쇠를 포함한 공간 오디오

---

## 📊 기술 사양

### 성능 지표
- **목표 FPS**: 90 FPS (VR 최적화)
- **네트워크 틱 레이트**: 60 Hz (Photon Fusion)
- **본 동기화**: 100개 본 @ 30 FPS
- **얼굴 동기화**: 6채널 @ 60 FPS
- **최대 플레이어**: 동시 20명 사용자

### 시스템 요구사항

#### 최소 사양
- **OS**: Windows 10 64비트
- **CPU**: Intel i5-8400 / AMD Ryzen 5 2600
- **GPU**: GTX 1070 / RX 580
- **RAM**: 16 GB
- **저장 공간**: 10 GB 여유 공간

#### 권장 사양
- **OS**: Windows 11 64비트
- **CPU**: Intel i7-10700K / AMD Ryzen 7 3700X
- **GPU**: RTX 3070 / RX 6700 XT
- **RAM**: 32 GB
- **저장 공간**: 10 GB SSD 공간

---

## 🤝 개발 가이드라인

### 코드 구조
- 명확한 관심사 분리를 통한 **모듈식 설계**
- 멀티플레이어 호환성을 위한 **네트워크 우선 아키텍처**
- 전반적인 **VR 최적화 성능**
- 중요 시스템의 **광범위한 문서화**

### 네이밍 컨벤션
```csharp
// 클래스: PascalCase
public class VRIKNetworkPlayer : NetworkBehaviour

// 메서드: PascalCase
public void CalibrateVRSystem()

// 변수: camelCase
private Transform headTarget;

// 상수: UPPER_SNAKE_CASE
private const string API_ENDPOINT = "http://localhost:8000";
```

### 아키텍처 패턴
- Unity 모범 사례를 따르는 **컴포넌트 기반 설계**
- 이벤트 시스템을 위한 **옵저버 패턴**
- 매니저 및 지속 데이터를 위한 **싱글톤 패턴**
- 오브젝트 생성 및 풀링을 위한 **팩토리 패턴**

---

## 📝 API 참조

### 핵심 클래스

#### `VRIKNetworkPlayer`
```csharp
public class VRIKNetworkPlayer : NetworkBehaviour
{
    // 네트워크 동기화된 본 데이터
    [Networked, Capacity(100)] public NetworkArray<Quaternion> BoneRotations

    // 얼굴 추적 동기화
    [Networked] public float FacialJaw { get; set; }
    [Networked] public float FacialSmile { get; set; }

    // VR 보정 메서드
    public void StartCalibration()
    public void ApplyCalibrationData(CalibrationData data)
}
```

#### `Api_Reaction`
```csharp
public class Api_Reaction : MonoBehaviour
{
    // AI 반응 처리
    public void SendToServer(string chatText, string gestureType = "", string audioPath = "")

    // 결과 처리
    public class Result { public bool trigger; public string effect; }
}
```

#### `FullyAutomatedVRCalibration`
```csharp
public class FullyAutomatedVRCalibration : MonoBehaviour
{
    // 자동 VR 설정
    public void StartAutomaticCalibration()
    public bool IsCalibrationComplete { get; }
}
```

### 이벤트 시스템
```csharp
// 시스템 통신을 위한 커스텀 이벤트
public static class VStageEvents
{
    public static UnityAction<CalibrationData> OnCalibrationComplete;
    public static UnityAction<EmotionData> OnEmotionDetected;
    public static UnityAction<string> OnEffectTriggered;
}
```

---

## 🔍 문제 해결

### 일반적인 문제

#### VR 추적 문제
```
문제: 아바타가 VR 움직임을 따라가지 않음
해결책:
1. VR 헤드셋 연결 확인
2. SteamVR 실행 여부 확인
3. 인앱 도구를 사용하여 재보정
4. 추적 공간 원점 재설정
```

#### 네트워크 연결 문제
```
문제: Photon 서버에 연결할 수 없음
해결책:
1. 인터넷 연결 확인
2. Photon 앱 ID 구성 확인
3. 방화벽 설정 확인
4. Network 씬으로 먼저 테스트
```

#### 성능 문제
```
문제: VR 모드에서 낮은 FPS
해결책:
1. VR 설정에서 렌더 해상도 낮추기
2. 필수가 아닌 시각 효과 비활성화
3. GPU 호환성 확인
4. 그래픽 드라이버 업데이트
```

### 디버그 도구
- **Unity 콘솔** - 런타임 오류 추적
- **Photon 통계** - 네트워크 성능 모니터링
- **VR 성능 오버레이** - FPS 및 프레임 타이밍
- **커스텀 디버그 UI** - 실시간 시스템 상태

---

## 🤝 기여하기

### 개발 워크플로우
1. 저장소 **포크**
2. 기능 브랜치 **생성** (`git checkout -b feature/AmazingFeature`)
3. 변경사항 **커밋** (`git commit -m 'Add AmazingFeature'`)
4. 브랜치에 **푸시** (`git push origin feature/AmazingFeature`)
5. 풀 리퀘스트 **생성**

### 코드 표준
- Unity C# 코딩 표준 준수
- 공개 API에 대한 XML 문서 포함
- 핵심 기능에 대한 단위 테스트 작성
- 모든 기능에 대한 VR 호환성 보장

### 테스트 체크리스트
- [ ] 대상 하드웨어에서 VR 기능 테스트
- [ ] 네트워크 동기화 확인
- [ ] 성능이 목표 FPS 충족
- [ ] 크로스플랫폼 호환성 확인

---

## 📄 라이선스

이 프로젝트는 MIT 라이선스에 따라 라이선스가 부여됩니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

---

## 🙏 감사의 글

### 서드파티 자산
- **[FinalIK](https://assetstore.unity.com/packages/tools/animation/final-ik-14290)** - 고급 역운동학 시스템
- **[Photon Fusion](https://www.photonengine.com/fusion)** - 고성능 네트워킹 솔루션
- **[lilToon](https://github.com/lilxyzw/lilToon)** - 아니메 스타일 셰이더 시스템
- **[MagicaCloth](https://assetstore.unity.com/packages/tools/physics/magica-cloth-160144)** - 전문 천 시뮬레이션

### 개발팀
- **핵심 개발** - 고급 VR 시스템 및 네트워킹
- **아트 & 애니메이션** - 캐릭터 디자인 및 시각 효과
- **AI 통합** - 감정 인식 및 반응 시스템
- **성능 최적화** - VR 전용 최적화

---

## 📞 지원

### 커뮤니티
- **Discord**: [VStage Community](https://discord.gg/vstage)
- **포럼**: [Unity Forums](https://forum.unity.com)
- **문서**: [Unity XR Documentation](https://docs.unity3d.com/Manual/XR.html)

### 전문 지원
상용 라이선스 및 전문 지원에 대해서는 다음으로 문의하세요: [support@vstage.com](mailto:support@vstage.com)

---

<div align="center">

**VR 커뮤니티를 위해 ❤️로 제작**

![Unity](https://img.shields.io/badge/Made%20with-Unity-black?style=for-the-badge&logo=unity)

*VStage Win Public - 가상 공연의 경계를 넓혀가다*

</div>

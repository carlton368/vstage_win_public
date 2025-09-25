# VStage Win Public - Advanced Unity VR Performance Platform

<div align="center">

![Unity](https://img.shields.io/badge/Unity-6000.1.2f1-000000?style=for-the-badge&logo=unity)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp)
![VR](https://img.shields.io/badge/VR-Ready-blue?style=for-the-badge)
![Photon](https://img.shields.io/badge/Photon-Fusion-ff6600?style=for-the-badge)
![Platform](https://img.shields.io/badge/Platform-Windows-blue?style=for-the-badge)

*A professional-grade Unity VR application featuring real-time networking, advanced character control, and AI-powered audience interaction for virtual stage performances.*

</div>

---

## 🚀 Overview

VStage Win Public is a sophisticated Unity-based virtual reality performance platform that enables immersive stage experiences with advanced networking capabilities. The application combines VR tracking, real-time facial animation, AI-powered audience reactions, and professional-grade networking to create a comprehensive virtual stage environment.

### Key Features

#### 🥽 **Advanced VR Integration**
- **VRIK (Virtual Reality Inverse Kinematics)** - Full-body VR tracking with FinalIK
- **Multi-platform VR Support** - Compatible with SteamVR, Oculus, and HTC Vive
- **Automated Calibration** - Smart VR setup with persistent calibration data
- **Ground Constraint System** - Realistic avatar positioning and movement

#### 🌐 **High-Performance Networking**
- **Photon Fusion** - Tick-based networking for precise synchronization
- **Host-Client Architecture** - Optimized for performance scenarios
- **Bone-level Synchronization** - Real-time avatar pose sharing (100 bones)
- **Performance Timeline Sync** - Coordinated show timing across all clients

#### 🎭 **Character & Animation System**
- **Facial Tracking** - 6-channel facial expression capture and sync
- **Humanoid Avatar Support** - Advanced rigging with 709+ scripts
- **Cloth Simulation** - MagicaCloth V2 integration for realistic fabric physics
- **Animation Timeline** - Professional timeline control for performances

#### 🤖 **AI-Powered Interactions**
- **Emotion Recognition** - Real-time chat analysis for audience reactions
- **Dynamic Effect Triggers** - AI-driven visual effects based on sentiment
- **Voice Processing** - WebSocket-based real-time voice streaming
- **Microphone Integration** - Advanced audio recording and processing

#### 🎨 **Visual & Audio Systems**
- **URP (Universal Render Pipeline)** - Optimized rendering for VR
- **lilToon Shaders** - Professional anime-style character rendering
- **VFX Graph** - Advanced particle systems and visual effects
- **Volumetric Lighting** - Atmospheric lighting with URP integration
- **Real-time Audio** - Spatial audio with microphone recording

---

## 📁 Project Structure

```
VStage_Win_Public/
├── 📂 Assets/
│   ├── 📂 01_Scenes/              # Unity scenes (100+ scenes)
│   │   ├── Artist_app_final.unity    # Main application scene
│   │   ├── Character.unity            # Character testing scene
│   │   ├── Network.unity              # Networking test scene
│   │   └── ...                        # Demo and test scenes
│   │
│   ├── 📂 02_Prefabs/             # Reusable game objects (211 prefabs)
│   │   ├── Characters/                # Avatar prefabs
│   │   ├── VFX/                      # Visual effects
│   │   └── UI/                       # User interface elements
│   │
│   ├── 📂 03_Scripts/             # C# Scripts (709 scripts)
│   │   ├── Api/                      # API integration & voice
│   │   ├── Calibration/              # VR calibration system
│   │   ├── Facial/                   # Facial tracking
│   │   ├── Photon/                   # Networking components
│   │   ├── UI/                       # Interface controllers
│   │   └── ...                       # Core systems
│   │
│   ├── 📂 Art/                    # Visual assets (667 media files)
│   │   ├── Characters/               # 3D character models
│   │   ├── Background/               # Stage environments
│   │   ├── VFX/                      # Visual effects assets
│   │   ├── UI asset/                 # Interface graphics
│   │   └── Animations/               # Animation clips
│   │
│   ├── 📂 Audio/                  # Audio assets
│   ├── 📂 Plugins/                # Third-party plugins
│   │   ├── RootMotion/FinalIK/       # Advanced IK system
│   │   └── ...                       # Other plugins
│   │
│   ├── 📂 MagicaCloth2/           # Cloth simulation system
│   ├── 📂 Photon/                 # Photon Fusion networking
│   ├── 📂 XR/                     # VR/XR integration
│   └── 📂 ThirdParty/             # External assets
│
├── 📂 ProjectSettings/            # Unity project configuration
├── 📂 Packages/                   # Package manager dependencies
└── 📄 README.md                   # This file
```

---

## 🛠 Technology Stack

### Core Technologies
| Technology | Version | Purpose |
|------------|---------|---------|
| **Unity Engine** | 6000.1.2f1 | Core game engine |
| **C# .NET** | Framework 4.7.1 | Primary scripting language |
| **Universal RP** | 17.1.0 | Rendering pipeline |
| **Input System** | 1.14.0 | Modern input handling |

### VR & Tracking
| Plugin | Purpose |
|--------|---------|
| **FinalIK** | Advanced inverse kinematics |
| **Unity XR Toolkit** | Cross-platform VR support |
| **SteamVR Plugin** | Valve Index/Vive support |
| **Oculus Integration** | Meta Quest support |
| **HTC Vive OpenXR** | HTC hardware support |

### Networking & Communication
| System | Purpose |
|--------|---------|
| **Photon Fusion** | High-performance networking |
| **WebSocket Client** | Real-time voice streaming |
| **Unity Netcode** | Network object management |
| **JSON.NET** | Data serialization |

### Visual & Audio
| Asset | Purpose |
|-------|---------|
| **lilToon Shader** | Anime-style character rendering |
| **MagicaCloth V2** | Advanced cloth simulation |
| **VFX Graph** | Particle system creation |
| **Cinemachine** | Dynamic camera control |
| **Timeline System** | Cutscene and animation sequencing |

---

## 🎯 Core Systems Deep Dive

### 1. VR Tracking System
```csharp
// VRIKNetworkPlayer.cs - Host VR tracking with network sync
[Networked, Capacity(100)] public NetworkArray<Quaternion> BoneRotations
[Networked] public Vector3 RootPosition { get; set; }
[Networked] public Quaternion RootRotation { get; set; }
```
- **Full-body tracking** with 100+ bone synchronization
- **Automatic calibration** with persistent data storage
- **Ground constraint** system for realistic movement
- **Multi-user support** with host-client architecture

### 2. AI Reaction System
```csharp
// Api_Reaction.cs - AI-powered audience interaction
private string apiUrl = "http://192.168.0.64:8000/process-form";
public class Result { public bool trigger; public string effect; }
```
- **Real-time emotion analysis** from chat input
- **Dynamic effect triggering** based on sentiment
- **WebSocket integration** for live communication
- **Scalable API architecture** for external services

### 3. Facial Tracking
```csharp
// SimpleShinanoFacialTracking.cs - 6-channel facial sync
[Networked] public float FacialJaw { get; set; }
[Networked] public float FacialSmile { get; set; }
// + 4 more channels for complete expression capture
```
- **6-channel expression tracking** (Jaw, Smile, Wide, O, Sad, Tongue)
- **Real-time network synchronization** across all clients
- **Anime-style facial animation** optimized for virtual avatars

---

## 🚀 Quick Start Guide

### Prerequisites
- **Unity 6000.1.2f1** or later
- **Windows 10/11** (64-bit)
- **VR Headset** (SteamVR compatible)
- **Minimum 16GB RAM**
- **GTX 1070** or equivalent GPU

### Installation Steps

1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-repo/vstage-win-public.git
   cd vstage-win-public
   ```

2. **Unity Setup**
   - Open Unity Hub
   - Add project from disk
   - Install Unity 6000.1.2f1 if needed
   - Wait for package resolution (may take 5-10 minutes)

3. **Package Configuration**
   ```json
   // Key packages in manifest.json
   "com.unity.xr.interaction.toolkit": "3.1.2"
   "com.unity.render-pipelines.universal": "17.1.0"
   "com.unity.inputsystem": "1.14.0"
   ```

4. **VR Hardware Setup**
   - Connect and calibrate your VR headset
   - Ensure SteamVR is running
   - Configure tracking space in VR settings

5. **Network Configuration**
   - Set up Photon App ID in Photon settings
   - Configure network endpoints in scripts
   - Test connection with Network scene

### First Run
1. Open `Artist_app_final.unity` scene
2. Configure VR settings in Project Settings > XR Plug-in Management
3. Build and run or test in Play Mode
4. Follow in-VR calibration prompts

---

## 🎮 Usage Guide

### Main Scenes

#### 🎭 **Artist_app_final.unity**
- **Primary application scene** for live performances
- Full VR integration with audience interaction
- AI-powered reaction system active
- Professional timeline controls

#### 👤 **Character.unity**
- Character testing and customization
- Facial tracking calibration
- Avatar setup and rigging tests

#### 🌐 **Network.unity**
- Networking functionality testing
- Multi-user connection setup
- Performance optimization testing

### Key Controls

| Action | Input | Description |
|--------|-------|-------------|
| **Calibrate VR** | Trigger Menu | Auto-calibration sequence |
| **Toggle Effects** | Grip Button | VFX system toggle |
| **Voice Record** | Y/B Button | Microphone activation |
| **Menu Navigation** | Touchpad | UI interaction |

### Performance Features

#### Timeline Control
- **Professional sequencing** for coordinated performances
- **Multi-track animation** with precise timing
- **Real-time synchronization** across network clients
- **Effect triggering** based on performance cues

#### Audience Interaction
- **Chat processing** through AI emotion recognition
- **Dynamic lighting** responses to audience sentiment
- **Effect triggers** for crowd engagement
- **Real-time feedback** display system

---

## 🔧 Configuration

### Network Settings
```csharp
// Configure in PhotonSettings
public static class NetworkConfig
{
    public const string APP_ID = "YOUR_PHOTON_APP_ID";
    public const string APP_VERSION = "1.0";
    public const int MAX_PLAYERS = 20;
}
```

### VR Configuration
```csharp
// VR Settings in PlayerSettings
defaultScreenWidth: 1024
defaultScreenHeight: 768
virtualRealitySupported: true
stereoRenderingPath: SinglePassInstanced
```

### Performance Optimization
- **Render Pipeline**: Universal RP for VR optimization
- **Texture Streaming**: Enabled for large asset management
- **Physics**: Optimized for VR interaction
- **Audio**: Spatial audio with distance attenuation

---

## 📊 Technical Specifications

### Performance Metrics
- **Target FPS**: 90 FPS (VR optimized)
- **Network Tick Rate**: 60 Hz (Photon Fusion)
- **Bone Sync**: 100 bones @ 30 FPS
- **Facial Sync**: 6 channels @ 60 FPS
- **Max Players**: 20 concurrent users

### System Requirements

#### Minimum
- **OS**: Windows 10 64-bit
- **CPU**: Intel i5-8400 / AMD Ryzen 5 2600
- **GPU**: GTX 1070 / RX 580
- **RAM**: 16 GB
- **Storage**: 10 GB available space

#### Recommended
- **OS**: Windows 11 64-bit
- **CPU**: Intel i7-10700K / AMD Ryzen 7 3700X
- **GPU**: RTX 3070 / RX 6700 XT
- **RAM**: 32 GB
- **Storage**: 10 GB SSD space

---

## 🤝 Development Guidelines

### Code Structure
- **Modular design** with clear separation of concerns
- **Network-first architecture** for multiplayer compatibility
- **VR-optimized performance** throughout
- **Extensive documentation** in critical systems

### Naming Conventions
```csharp
// Classes: PascalCase
public class VRIKNetworkPlayer : NetworkBehaviour

// Methods: PascalCase
public void CalibrateVRSystem()

// Variables: camelCase
private Transform headTarget;

// Constants: UPPER_SNAKE_CASE
private const string API_ENDPOINT = "http://localhost:8000";
```

### Architecture Patterns
- **Component-based design** following Unity best practices
- **Observer pattern** for event systems
- **Singleton pattern** for managers and persistent data
- **Factory pattern** for object creation and pooling

---

## 📝 API Reference

### Core Classes

#### `VRIKNetworkPlayer`
```csharp
public class VRIKNetworkPlayer : NetworkBehaviour
{
    // Network synchronized bone data
    [Networked, Capacity(100)] public NetworkArray<Quaternion> BoneRotations

    // Facial tracking synchronization
    [Networked] public float FacialJaw { get; set; }
    [Networked] public float FacialSmile { get; set; }

    // VR calibration methods
    public void StartCalibration()
    public void ApplyCalibrationData(CalibrationData data)
}
```

#### `Api_Reaction`
```csharp
public class Api_Reaction : MonoBehaviour
{
    // AI reaction processing
    public void SendToServer(string chatText, string gestureType = "", string audioPath = "")

    // Result handling
    public class Result { public bool trigger; public string effect; }
}
```

#### `FullyAutomatedVRCalibration`
```csharp
public class FullyAutomatedVRCalibration : MonoBehaviour
{
    // Automated VR setup
    public void StartAutomaticCalibration()
    public bool IsCalibrationComplete { get; }
}
```

### Events System
```csharp
// Custom events for system communication
public static class VStageEvents
{
    public static UnityAction<CalibrationData> OnCalibrationComplete;
    public static UnityAction<EmotionData> OnEmotionDetected;
    public static UnityAction<string> OnEffectTriggered;
}
```

---

## 🔍 Troubleshooting

### Common Issues

#### VR Tracking Problems
```
Issue: Avatar not following VR movements
Solution:
1. Check VR headset connection
2. Verify SteamVR is running
3. Recalibrate using in-app tools
4. Reset tracking space origin
```

#### Network Connection Issues
```
Issue: Cannot connect to Photon servers
Solution:
1. Check internet connection
2. Verify Photon App ID configuration
3. Check firewall settings
4. Test with Network scene first
```

#### Performance Issues
```
Issue: Low FPS in VR mode
Solution:
1. Lower render resolution in VR settings
2. Disable non-essential visual effects
3. Check GPU compatibility
4. Update graphics drivers
```

### Debug Tools
- **Unity Console** - Runtime error tracking
- **Photon Statistics** - Network performance monitoring
- **VR Performance Overlay** - FPS and frame timing
- **Custom Debug UI** - Real-time system status

---

## 🤝 Contributing

### Development Workflow
1. **Fork** the repository
2. **Create** feature branch (`git checkout -b feature/AmazingFeature`)
3. **Commit** changes (`git commit -m 'Add AmazingFeature'`)
4. **Push** to branch (`git push origin feature/AmazingFeature`)
5. **Create** Pull Request

### Code Standards
- Follow Unity C# coding standards
- Include XML documentation for public APIs
- Write unit tests for core functionality
- Ensure VR compatibility for all features

### Testing Checklist
- [ ] VR functionality tested on target hardware
- [ ] Network synchronization verified
- [ ] Performance meets target FPS
- [ ] Cross-platform compatibility confirmed

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 🙏 Acknowledgments

### Third-Party Assets
- **[FinalIK](https://assetstore.unity.com/packages/tools/animation/final-ik-14290)** - Advanced inverse kinematics system
- **[Photon Fusion](https://www.photonengine.com/fusion)** - High-performance networking solution
- **[lilToon](https://github.com/lilxyzw/lilToon)** - Anime-style shader system
- **[MagicaCloth](https://assetstore.unity.com/packages/tools/physics/magica-cloth-160144)** - Professional cloth simulation

### Development Team
- **Core Development** - Advanced VR systems and networking
- **Art & Animation** - Character design and visual effects
- **AI Integration** - Emotion recognition and response systems
- **Performance Optimization** - VR-specific optimizations

---

## 📞 Support

### Community
- **Discord**: [VStage Community](https://discord.gg/vstage)
- **Forums**: [Unity Forums](https://forum.unity.com)
- **Documentation**: [Unity XR Documentation](https://docs.unity3d.com/Manual/XR.html)

### Professional Support
For commercial licensing and professional support, please contact: [support@vstage.com](mailto:support@vstage.com)

---

<div align="center">

**Made with ❤️ for the VR community**

![Unity](https://img.shields.io/badge/Made%20with-Unity-black?style=for-the-badge&logo=unity)

*VStage Win Public - Pushing the boundaries of virtual performance*

</div>
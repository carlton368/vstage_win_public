# VStage Win Public

A Unity-based virtual stage application featuring VR support and real-time networking capabilities.

## Features

- **VR Integration**: Full VR support with VRIK (Virtual Reality Inverse Kinematics) for immersive character control
- **Multiplayer Networking**: Real-time networking using Photon Fusion for shared virtual experiences
- **Character System**: Advanced character system with facial tracking and animation presets
- **Audio Integration**: Real-time voice recording and WebSocket-based audio streaming
- **AI-Powered Reactions**: Emotion keyword detection and AI-driven audience reaction system
- **VFX System**: Dynamic visual effects and lighting controls for stage performances
- **Calibration System**: Automated VR calibration for optimal tracking accuracy

## Project Structure

```
Assets/
├── 01_Scenes/          # Unity scenes
├── 02_Prefabs/         # Reusable game objects
├── 03_Scripts/         # C# scripts
│   ├── Api/            # API integration and voice handling
│   ├── Calibration/    # VR calibration system
│   ├── Facial/         # Facial tracking implementation
│   ├── Photon/         # Networking components
│   └── ...
├── Art/                # 3D models, animations, textures
└── Plugins/            # Third-party plugins (FinalIK, etc.)
```

## Key Components

- **FinalIK**: Advanced inverse kinematics system for realistic VR avatar movement
- **Photon Fusion**: High-performance networking solution
- **lilToon**: Anime-style shader system for character rendering
- **MagicaCloth**: Cloth simulation system
- **WebSocket Integration**: Real-time communication for voice and data

## Getting Started

1. Open the project in Unity (compatible with Unity 2021.3 or later)
2. Import required packages and dependencies
3. Configure Photon settings for networking
4. Set up VR hardware and calibration
5. Run the main scene to start the virtual stage experience

## Scenes

- **Artist_app_final**: Main application scene
- **Character**: Character setup and testing
- **Network**: Networking configuration and testing
- **SampleScene**: Basic sample implementation

## Dependencies

- Unity XR Interaction Toolkit
- Photon Fusion
- FinalIK
- lilToon Shader
- MagicaCloth V2
- Various VR SDKs (SteamVR, Oculus)
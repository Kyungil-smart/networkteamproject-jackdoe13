# Tech Specification

## Unity 환경

| 항목 | 결정 사항 |
|------|----------|
| Unity 버전 | Unity 6000.3 |
| 렌더 파이프라인 | URP |
| 빌드 플랫폼 | Windows |
| 타겟 해상도 | FHD (1920 * 1080) |
| 타겟 프레임레이트 | 30 ~ 60 |
| 스크립팅 백엔드 | Mono |

---

## 입력 시스템

- **New Input System** 사용 (`UnityEngine.InputSystem`)
- 구형 `Input.GetKey()` 방식 사용 금지
- Generate C# class로 처리

---

## UI 시스템

- **uGUI** (`UnityEngine.UI`) 사용

---

## 오디오 시스템

- Unity 기본 **AudioSource / AudioClip** 사용

---

## 씬 관리

- Unity 기본 **SceneManager** 사용
- 씬 전환은 SceneLoader 전용 클래스를 통해서만 처리

---

## 물리 시스템

- 미정 (2D / 3D 추후 결정)

---

## 추가 패키지

- 
---

## 네트워크

- Unity Multiplayer (Relay, Netcode for Gameobject)
- Firebase (Auth, Realtime Database)

---

*결정되지 않은 항목은 협의 후 업데이트합니다.*

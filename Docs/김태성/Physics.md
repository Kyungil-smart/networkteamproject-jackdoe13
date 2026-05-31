# 물리 및 충돌처리
## Rigidbody
게임 오브젝트에 물리 및 중력의 연산과 함수를 사용할 수 있는 컴포넌트. 

#### 주요 함수

  - **AddForce(x, y, z) :** 매개변수로 입력되는 방향으로 힘을 가함. (입력을 반복할수록 힘이 누적됨)
  - **AddTorque() :** 매개변수로 입력되는 축의 회전력을 가함
  - **velocity :** 게임 오브젝트에 가해지고 있는 물리력
  - **angularVelocity :** 게임 오브젝트에 가해지고 있는 회전력


#### 실습코드

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyStudy : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    [SerializeField] private float _force;
    [SerializeField] private float _velocityValue;
    
    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            _rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);    
        }
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _rigidbody.linearVelocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
        }
    }
    
}
```

- **발생한 문제**
 
1. **Rigidbody 소스코드 작성 후 테스트 과정에서 키 입력이 되지않고 에러 메시지 출력**
```
InvalidOperationException: You are trying to read Input using the UnityEngine.Input class, but you have switched active Input handling to Input System package in Player Settings. UnityEngine.Input.GetKeyDown (UnityEngine.KeyCode key) (at <963eca93f6f94ccd8e0ec96595c4884f>:0)
RigidbodyStudy.Update () (at Assets/Scenes/RigidbodyStudy.cs:24)
```
- **문제 해결방법**  
  1-1. using System.Collection.Generic; 추가  
  1-2. **Edit -> ProjectSetting -> Player -> Active Input Handling -> Both로 변경**

## Collider
게임 오브젝트끼리 충돌을 가능케하는 컴포넌트

- Collision  
두 게임 오브젝트 간의 충돌처리에 사용.  
둘 다 Rigidbody 컴포넌트가 활성화 되어있어야 하고, IsTrigger는 체크 해제 되어있어야 함. 

- Trigger  
  특정 공간에 진입했는지 체크할 때 주로 사용.
  두 게임 오브젝트 중에 하나는 Rigidbody가 활성화 되어있어야 하고, IsTrigger가 체크 되어있어야 함.
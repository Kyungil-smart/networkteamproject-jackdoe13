Rigidbody : 게임 Object에 물리엔진을 적용하는 Component

Rigidbody에서 지원되는 함수들
    - AddForce(x,y,z) : 매개변수로 입력되는 x,y,z축 방향으로 힘을 가함, 입력이 반복될수록 누적
  - AddTorque() : 매개변수로 입력되는 축의 회전력 추가
  - velocity : Object에 가해지는 물리력
  - angularVelocity : Object에 가해지는 회전력

Collision
  - 주로 활성화 된 Object간의 충돌처리에 사용
  - Collider Component의 Is Trigger가 선택 해제 상태이어야 함
  - 자신과 충돌 대상 모두에 Rigidbody Component 추가
  - 둘 중 하나의 Rigidbody 에는 Iskinematic이 선택 해제 상태이어야 함

Trigger
  - 주로 특정 장소 도달 등의 상황에 사용
  - Collider Component의 Is Trigger가 선택되어 있어야 함
  - 선택 시 물리적인 충돌 진행 X, 통과됨 O
  - 자신 또는 충돌 대상 중 하나에 Rigidbody component 추가


관련 메서드

    Enter : 충돌 시 1회 실행 
      - OnCollisionEnter(Collision other)
      - OnTriggerEnter(Collider other)
    Stay : 충돌 상태 유지 시 반복 실행 
           (지속호출로 인한 사용 지양)
      - OnCollisionStay(Collision other)
      - OnTriggerStay(Collider other)
    Exit : 충돌 종료 시 (충돌에서 벗어나는 순간) 1회 실행
      - OnCollisionExit(Collision other)
      - OnTriggerExit(Collider other)


```csharp
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class RigidbodyTest : MonoBehaviour
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
        // _rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
        //_rigidbody.AddTorque(Vector3.up * _force);
        //_rigidbody.linearVelocity = Vector3.up * _velocityValue;
        _rigidbody.angularVelocity = Vector3.up * _velocityValue;
      }

      if (Input.GetKeyDown(KeyCode.Z))
      {
         _rigidbody.linearVelocity = Vector3.zero;
         _rigidbody.angularVelocity = Vector3.zero;
      }
   }
}

```
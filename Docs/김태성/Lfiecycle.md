# Lifecyle

유니티에서 스크립트가 실행되는 동안 이벤트 함수가 어떤식으로 돌아가는지 나타냄

### Awake
 항상 Start 함수 전에 호출되며 프리팹이 인스턴스화 된 직후에 호출됨.

### OnEnable
 오브젝트가 활성화 된 직후 호출됨.

 ### Start
 인스턴스가 활성화된 경우 Update 첫 프레임 전에 호출됨.

 ### Update
 매 프레임마다 호출됨.

 ### LateUpdate
 Update가 끝난 후 매 프레임당 한번 호출됨. (카메라시점 갱신할 때 많이 사용)

 ### FixedUpdate
 프레임과 상관 없이 타이머로 호출됨.

 ### OnDisable
 동작이 비활성화되거나 비활성 상태일때 호출됨.

 ### OnDestroy
오브젝트의 마지막 프레임 업데이트를 마친 뒤 호출되고 오브젝트를 파괴함.

 ### OnApplicationQuit
 실행 종료.

 ``` csharp
using System;
using UnityEngine;

public class Lifecycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake 출력");
    }
    
    void OnEnable()
    {
        Debug.Log("OnEnable 출력");
    }
    
    void Start()
    {
        Debug.Log("Start 출력");
    }
    
    void Update()
    {
        Debug.Log("Update 출력");
    }    
    
    void LateUpdate()
    {
        Debug.Log("LateUpdate 출력");
    }    
    
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate 출력");
    }
    
    void OnDisable()
    {
        Debug.Log("OnDisable 출력");
    }    
    
    void OnDestroy()
    {
        Debug.Log("Destroy 출력");
    }
 }
 ```
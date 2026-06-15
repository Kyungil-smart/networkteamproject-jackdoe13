# 애니메이션(Animation)과 FSM - 3D

## ⭐ FSM(유한 상태 머신)

### ✅ 개념

1. 객체가 한 번에 하나의 상태만 가질 수 있도록 제어하는 모델.
2. 각 시스템 별 상태들 관계를 관리 및 전이하는 디자인 패턴 일종으로 상태 패턴과 가깝다.

### ✅ 특징

1. 상태 변화에 따른 여러 동작을 구현해야 될 때 많이 사용.
2. Animation Controller을 생성하여 상태변화에 따른 애니메이션을 유동적(상황에 맞게 처리)으로 관리.
3. 하나 또는 여러 개의 parameter를 사용하여 오브젝트의 상태 및 움직임을 표현.

### ✅ 구조

    ```
    현재 상태(State) + 조건(Parameter) -> 상태 전이(Transition)
    ```

1. Idle <-> Walking
2. Walking <-> Running

### ✅ 구성 요소

1. 상태: 이동 중, 체력 고갈 상태, 달리기 중 -> 객체가 현재 어떤 상태인지 나타냄.
2. 조건: 이동, 달리기, 공격 등의 행동을 하기 위한 조건 -> 상태를 변경하기 위한 판단 기준.
3. 상태 전이: 전환 조건이 충족 시 다른 상태로 진입.


## ⭐ Unity 애니메이션(Animation) 구성 요소

### 🎯 애니메이션(Animation)

#### ✅ 개념

1. 단일의 애니메이션을 적용하기 위한 컴포넌트

#### ✅ 특징

1. 게임 오브젝트에 직접 붙여서 사용.
2. 구버전 애니메이션 구현 방식으로 옛날 방식의 게임을 만들고자 할 떄나 단발성 연출에 쓰임.
3. 거의 유니티 구버전에서만 사용.
4. 코드 짜기가 Animator에 비해 어렵고 전이 조건도 직접 코드를 짜야해서 관리하기 어려움.
5. 예외(오류) 처리가 어려움.
6. 애니메이션 클립(Animation Clip)를 코드로 호출해서 구현하는 방식.
7. 애니메이션 클립(Animation Clip)은 시간에 따라 값이 변하는 데이터를 저장하며 legacy형태여만 애니메이션 구현이 가능.
8. .anim 파일

#### ✅ 컴포넌트

![alt text](image-1.png)

### 🎯 애니메이터(Animator)

#### ✅ 개념

1. 애니메이션 컨트롤러를 객체에 적용하기 위한 컴포넌트
2. 여러 개의 애니메이션을 관리하는 시스템

#### ✅ 특징

1. Parameter로 조건을 간단하게 코드 작성하여 쉽게 구현 가능.
2. FSM의 기능을 수행하며 FSM 구조로 구성.
3. Animator Controller: 애니메이션의 흐름을 정의하는 FSm 설계도. 
4. 관리하기 편하고 Animation 보다 관리하기 쉽다.
5. 유니티 최신 버전에서 많이 사용.
6. .controller 파일

#### ✅ 컴포넌트

![alt text](image-2.png)

#### ✅ 애니메이터(Animator) 구조: State

1. Idle, Walking, Running 등의 각 상태를 나타내는 단위
2. 노드(데이터나 기능을 담고 있는 하나 단위).
3. 애니메이터 각 노드 컴포넌트에서 motion을 넣어줘야 작동

#### ✅ 애니메이터(Animator) 구조: Transition

1. 코드에서 애니메이터롤 보내는 데이터
2. 상태 전이 표시, 화살표
3. 상태(State)와 상태(State)를 잇는 통로
4. 컴포넌트에서 우선 순위 설정하여 상태 시작과 그 후 상태 순위를 정할 수 있다.
5. Entry: 게임 시작 시 처음 에니매이션 작동 조건
6. Make Transition: 화살표를 생성하여 각 상태에 전이
7. Set as Layer Default State: 상태 진입 시 시작점.

![alt text](image-7.png)

#### ✅ 애니메이터(Animator) 구조: parameter

1. 개념: 코드에서 애니메이터로 보내는 데이터

2. Conditions: Transition이 일어나기 위한 조건문

    ```
    a. Float: 속도 값에 많이 쓰임(이동 속도처럼 부드러운 변화).
    b. int: 동작 순서 값에 쓰임(무기 스왑).
    c. bool: 상태 체크(상태 허용 및 해제).
    d. Trigger: On/Off 형식의 단발성 이벤트(공격 모션처럼 단발성 이벤트).
    ```
![alt text](image-8.png)

3. Animator(FSM 구조)는 4가지 parameter들로 state(노드) 간 transition(상태 전이)를 제어.

### 🎯 Animation Clip(녹화본)

#### ✅ 개념

1. Animation과 Animator가 둘 다 사용하는 것
2. 객체의 움직임을 미리 정의한(저장한) 파일

## ⭐ Skinned Mesh Renderer 컴포넌트

### ✅ 개념

1. 뼈의 움직임에 따라 변형되는 메시(mesh)를 화면에 그리는 컴포넌트
2. 그래픽 디자이너가 Blender 작업 할 때 오브젝트에 뼈대 작업(Riging)하여 생동감 있게 구현한 것으로 유니티에 나타는 컴포넌트


## ⭐ Animation 테스트 1: 기본적인 구조와 기능

1. 컴포넌트 설정

    a. 오브젝트에 Animation 컴포넌트 적용
    b. 오브젝트 컴포넌트 Debug롤 설정 후 asset으로 받은 각 상태 Animation Clip들을 legacy 형태로 변경


2. 코드

    ```csharp
    using UnityEngine;

    public class Animation_Test : MonoBehaviour
    {
        Animation _anim;

        private void Awake()
        {
            // 애니메이션 컴포넌트를 가져옴
            _anim = GetComponent<Animation>();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                // bool 타입의 Play는 string을 매개변수로 포함
                _anim.Play("Idle");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                _anim.Play("Walking");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                _anim.Play("Running");
            }
        }
    }
    ```

** Play()는 재생 성공 여부를 bool 값으로 반환하며 string 타입의 상태(State) Animation Clip 이름을 매개변수로 받으며, 해당 이름이 Animation 컴포넌트에 등록된 Animation Clip 이름과 일치해야 재생한다.

2. 결과
    
    a. 오브젝트가 각 상태가 실행되게 설정한 키를 눌렀을 때 동작

    ![alt text](image-3.png)

    ![alt text](image-4.png)

    ![alt text](image-5.png)

## ⭐ Animator 테스트 2: 기본적인 구조와 기능

1. 코드

    ```csharp
    using UnityEngine;

    public class Jellyman_Controller : MonoBehaviour
    {
        Animator _animator;
        float _speed;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha4))
            {
                // Idle
                _speed = 0f;
            }
            else if(Input.GetKeyDown(KeyCode.Alpha5))
            {
                // Walking
                _speed = 1f;
            }
            else if(Input.GetKeyDown(KeyCode.Alpha6))
            {
                // Running
                _speed = 2;
            }

            // 생성한 Parameter 이름과 동일해야 적용됨.
            _animator.SetFloat("MoveSpeed", _speed);
        }
    }
    ```

2. 애니메이터 적용 순서

    ```
    a. parameter에서 float형 생성
    b. condition(Idle -> Walking 전이): float형 생성 후 greater 0.1로 이동속도 조정, has Exit time 해제.
    c. condition(Idle <- Walking 전이): float형 생성 후 less 0.1로 이동속도 조정, has Exit time 해제.
    d. condition(Walking -> Running 전이): float형 생성 후 greater 1.1로 이동속도 조정, has Exit time 해제.
    e. condition(Walking <- Running 전이): float형 생성 후 less 1.1로 이동속도 조정, has Exit time 해제.
    f. condition(Running -> Idle 전이): float형 생성 후 less 0.1로 이동속도 조정, has Exit time 해제.
    g. condition(Running <- Idle 전이): float형 생성 후 greater 1.1로 이동속도 조정, has Exit time 해제.
    h. animation clip 컴포넌트에서 Loop time 체크
    ```

3. 결과

    - 가만히 있는상태(4번 키)

    ![alt text](image-9.png)

    - 걷는 상태(5번 키)

    ![alt text](image-10.png)

    - 달리는 상태(6번 키) 

    ![alt text](image-11.png)

## ⭐ Animator 테스트 3: float, int, bool, trigger

1. 코드

    ```csharp
    using UnityEngine;

    public class AnimController_1 : MonoBehaviour
    {
        Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        // Animation
        private void Update()
        {
            // 1. float 이동: Walking, Running
            float moveInput = Input.GetAxisRaw("Vertical");

            float speed = Mathf.Abs(moveInput);


            if(Input.GetKey(KeyCode.LeftShift) && speed > 0)
            {
                speed = 2.0f;
            }

            if(moveInput == 0)
            {
                speed = 0f;
            }

            _animator.SetFloat("MoveSpeed", speed);

            // 2. int 무기 교체:
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                // Drawing Gun
                _animator.SetInteger("WeaponType", _animator.GetInteger("WeaponType") == 1 ? 0 : 1);
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                // Drawing Sword
                _animator.SetInteger("WeaponType", _animator.GetInteger("WeaponType") == 2 ? 0 : 2);
            }

            // 3. bool 싸움 준비 태세
            bool isFight = Input.GetMouseButton(1);
            _animator.SetBool("FightIdle", isFight);
        }      
    }
    ```

2. Animator 노드 설정

    - Any State: 모든 상태 안에서 동작 가능하게 하는 노드
    - Can Transition To Self: Any State에서 전이 화살표에만 나타는 속성으로 동작 키를 한 번만 눌렀을 때 무한루프를 방지.
    - sub state machine: 여러 상태(State)를 묶어 관리하는 하위 상태 머신으로 관리할게 많은 상태를 묶어서 관리.

        ![alt text](image-16.png)

    - float: 걷기, 달리기
    - bool: 싸움 자세 및 조준
    - int: 무기 스왑 및 바꾸기
    - trigger: Attack

    - Main State Machine
    
        ![alt text](image-20.png)

    - Sub State Machine

        ![alt text](image-19.png)

3. 결과

    - Idle 상태

        ![alt text](image-12.png)

    - 전투 준비 상태

        ![alt text](image-13.png)

    - 무기 총으로 바꾸는 상태

        ![alt text](image-14.png)
    
    - 무기 검으로 바꾸는 상태

        ![alt text](image-15.png)
    
    - w: 걷기 상태
    - W + shift: 달리기 상태
    
    - 1 + 왼쪽 마우스: 공격

        ![alt text](image-17.png)

    - 2 + 왼쪽 마우스: 공격

        ![alt text](image-18.png)

## 참고자료

- FSM

    1. https://shin17blog.tistory.com/21
    2. https://seoksii.tistory.com/56
    3. https://dodobug.tistory.com/16
    4. https://tearsinrain.tistory.com/10
    5. https://gamecoke.tistory.com/entry/Unity-FSM-%EC%9C%A0%ED%95%9C-%EC%83%81%ED%83%9C-%EB%A8%B8%EC%8B%A0
    6. https://velog.io/@xoaud321/%EC%9C%A0%EB%8B%88%ED%8B%B0-%EB%94%94%EC%9E%90%EC%9D%B8-%ED%8C%A8%ED%84%B4-FSM-%ED%8C%A8%ED%84%B4-%EA%B5%AC%ED%98%84


https://russellstudio.tistory.com/137

https://spaceunderthe.tistory.com/59

https://devshovelinglife.tistory.com/488

https://artiper.tistory.com/359

https://www.ibatstudio.com/%EC%9C%A0%EB%8B%88%ED%8B%B0-%EC%95%A0%EB%8B%88%EB%A9%94%EC%9D%B4%EC%85%98-vs-%EC%95%A0%EB%8B%88%EB%A9%94%EC%9D%B4%ED%84%B0-%EB%91%90-%EC%BB%B4%ED%8F%AC%EB%84%8C%ED%8A%B8%EC%9D%98-%EC%B0%A8%EC%9D%B4/


과제

### 1. MonoBehaviour 상속 받는 클래스와 안받는 클래스간의 차이점


|기능|MonoBehaviour|일반 C# 클래스|
|:---:|:---:|:---:|
|GameObject 부착|O|X|
|Inspector 표시|O|X|
|Unity 생명주기 함수 사용|O|X|
|New 키워드|X(AddComponent())|O|
|성능(메모리)|무거움|가벼움|
|핵심 목적|게임 오브젝트의 동작제어|로직/데이터처리|




### 2. 두 가지 방법 다 클래스 생성 방법

**MonoBehaviour**  
AddComponent<T>()를 사용하여 기존 게임 오브젝트에 컴포넌트로 추가합니다.  
Instantiate()를 사용하여 프리팹을 씬에 생성합니다.

**일반 C# 클래스**  
New 키워드 사용

---
검색능력 키우기, 소통 좀 더 열심히 하기.
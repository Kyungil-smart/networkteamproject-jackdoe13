Keyword : 
FSM(유한상태머신) : 상태를 기반으로 동작을 제어하는 시스템, 객체는 한번에 하나의 상태만을 가진다는 논리로 제어하는 모델 [구조] 현재 상태(State) + 조건(Parameter) -> 상태 전이
Animation : 단일의 애니메이션을 적용하기 위한 컴포넌트
Animation Clip : 객체의 움직임을 미리 정의한(저장한) 파일.
Animation Controller : 애니메이션 클립을 등록, 객체의 상태에 따라 애니메이션들을 관리 또는 재생
Animator :  애니메이션 컨트롤러를 객체에 적용하기 위한 컴포넌트
Blender : 애니메이션간의 전환 시 두 애니메이션 클립을 결합, 자연스러운 움직임 만듦
----------------------------------------------------------------------------
Sprite Animatuion : Sprite 이미지를 일련의 시간 순서대로 변경하는 것
-> Inspector 창에서 Texture를 Sprite로 Mode를 Multiple로 사용
Pixel Pers Unit : Object Size가 카메라 기준으로 얼마나 잡힐 건지 설정
mesh type : 캐릭터배경 - Full Rect , 파티클 - Tight
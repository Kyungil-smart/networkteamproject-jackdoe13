### StateHandler

강사님이 주신 코드를 프로젝트에 적용해보기.

1. 구현 해야할 기능에 대한 공부
   
   - 코드 이해 기록 남기기
     - TurnHandler  
     ├ 현재 턴 관리  
     ├ 현재 플레이어 관리  
     ├ 제한시간 관리  
     └ 페이즈 전환 관리  
     - 각 페이즈  
     ├ TestPhase1   
     ├ TestPhase2  
     └ TestPhase3

   - 모르는 개념 기록해두기
     - 아직 Coroutine에 대해 제대로 모르겠다. 추가공부 필요
     - 
 
   - 뭘 실수했는지 기록해두기
     1. 실수로 유니티 3D로 생성해놓고 이거 왜 2D스프라이트 생성이 안되는거지 하며 시간을 소모함.
     2. Hierarchy에 있는 TestPhase 들의 Inspector에 TurnHandler 넣어두지도 않고 이거 왜안돼는거지 하며 시간을 보냄.
     3. Input System오류가 계속 떠서 이게 뭘까 고민함.

   - 해결 했을 시 해결 방법 기록.
     1. (실수 1번) 팀원들과 이야기해보며 해결방안을 찾아봄. 그래도 2D 오브젝트 생성이 안되어 더 시간끌기전에 프로젝트를 2D로 재생성. 
     2. (실수 2번) 뒤늦게 Inspecter에 해당사항 발견 후 바로 TestPhase 에 TurnHandler 적용.
     3. (실수 3번) Edit - Project Sattings - Player - Active Input Handling 의 Input System package를 Both 로 수정하자 해당 오류 사라짐.
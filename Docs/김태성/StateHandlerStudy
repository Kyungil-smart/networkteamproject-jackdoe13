# TurnHandler

작성일: 2026-05-12

작성자: 김태성

유니티버전: 6000.3.9f1

## 학습목표
  
  TurnHandler 활성화/비활성화가 어떻게 돌아가는지 눈으로 확인해보고 활용해보기
  
## 본문
  
**개요**

플레이어의 턴에서 각 페이즈를 타이머에 맞춰 돌아가게끔 해주는 로직

![alt text](image.png)

monobehavior를 상속받아 unity lifecycle를 따르는 함수가 실제 로직을 가지고 있고, 이 함수를 각각의 인터페이스에서 실행시키는 구조로 StateMachine은 player에게서 행동을 입력받았을 때 interface를 갈아끼우는 일을 담당한다. 

**학습내용**

별도의 프로젝트를 생성하여 패키지를 import하고 실행시킨 뒤 콘솔창에서 페이즈변경 로직 작동확인

**발생한 문제**

실행시 콘솔창에 null reference exeption 오류 출력

**해결과정**

edit - project settings - physics - player - other settings - active input handling: both로 변경 후 재시작

**추가로 해볼것**
FSM 구조를 먼저 파악하고 그 구조를 그대로 StatePattern으로 가져와서 만들어보며 이해하기


# Team Rule (팀 개발 규칙)

## 0. 팀 규칙

- 일정이 있다면 노션에 표기하기
- 일정 최소한 하루 전에 알리기
- 노션의 데일리 스크럼, 회고 잘 작성하기
  - [데일리 스크럼/회의 09:30, 회고 17:00]
- 갑자기 큰 소리 등으로 깜짝놀라게 하지 말 것. (개가 짖을 수 있음)
- 모르거나 막히는 거 있으면 30분 이상 지체될 시 공유 할 것.
- 야근이나 주말출근 강요하지 않기.
- 화가 나거나, 짜증이 날 경우 **냥체** 쓰기 (화가난다냥, 개빡친다냥)
- 작업중에 마이크 평소에 꺼두기.
- **우리 게임엔 미소녀가 없음.**

## 1. Git Commit Message 규칙

**타입 종류**

- feat: (기능 추가)
- fix: (버그 수정)
- chore: 기타 작업 (빌드, 설정)등

**작성 예시**
- feat: 플레이어 이동 기능 추가
- fix: 적이 공격하지 않는 버그 수정
- refactor: UI 구조 분리

---

## 2. 브랜치 생성 규칙 (필수)

**브랜치 구조**

- main -> 배포용 (절대 직접 작업 금지)
- develop -> 개발 통합 브랜치
- 이름 이니셜/* -> 기능 개발

**브랜치 예시**

- 이름 이니셜/player-movement
- 이름 이니셜/inventory-system

**규칙**

- main 브랜치 직접 작업 절대 금지
- 모든 작업은 develop 기준으로 진행
- develop에서만 브랜치 생성
- 작업 완료 후 Merge 진행
- 사용한 브랜치는 삭제 후 필요 시 재생성

---

## 3. 네이밍 규칙 (필수)

| 대상 | 규칙 | 예시 |
|------|------|------|
| 클래스 | PascalCase | `CoinSpawner`, `AssetManager` |
| 메서드 | PascalCase | `SpawnCoin()`, `CalculateDecay()` |
| 공개 프로퍼티 | PascalCase | `CurrentCash`, `FamePoint` |
| 비공개 필드 | _camelCase | `_spawnInterval`, `_comboCount` |
| 지역 변수 | camelCase | `decayValue`, `bounceCount` |
| 상수 | UPPER_SNAKE_CASE | `MAX_COMBO_COUNT`, `BASE_DECAY_RATE` |
| 인터페이스 | I + PascalCase | `IPoolable`, `IInvestable` |
| ScriptableObject | PascalCase + SO | `CoinDataSO`, `TierDataSO` |
| 이벤트 | On + PascalCase | `OnCoinCollected`, `OnTierChanged` |

## 접근 제한자
- 모든 필드/메서드에 접근 제한자를 **명시**한다. (생략 금지)
- Unity Inspector에 노출할 필드는 `private` + `[SerializeField]` 사용. `public` 필드 직접 노출 금지.

```
// 좋은 예
[SerializeField] private float _spawnInterval;

// 나쁜 예
public float spawnInterval;
```

---

## 4. Merge & Pull Request 커밋 규칙 (필수)

PR은 작업 내용을 명확하게 전달하는 문서다.

**📍 제목 형식**
- [기능] 캐릭터 선택 시스템 추가
- [버그] 적 공격 안하는 문제 수정

**📍 내용 작성 예시**
- Photon 동기화 구현
- 캐릭터 선택 UI 추가
- 100초 타이머 기능 구현

**📍 규칙**
- 무엇을 했는지 명확하게 작성
- 간결하게 작성
- 코드 확인 없이도 이해 가능하게 작성
- 커밋 시 -> 이슈 사항 있을 시 기재

---

  #  ★★★★★ 유니티 프로젝트 폴더 구조 가이드 ★★★★★
- Assets  
  - **importAssets 폴더**
    - 본인이 사용하는 에셋은 갱신(추가/삭제)될 때마다 Export As Asset Package 사용하셔서 따로 백업 바람.
  - **Scenes 폴더**
    -  Test 폴더 <-- 테스트를 하기 위한 용도 본인명 폴더 만든 후 테스트 바람.
    -  Main폴더 <-- 우리가 만들 게임의 씬 저장 폴더
    -  이니셜로 된 하위폴더를 만들어서 작업하기
  - **Scripts 폴더**
    - Common  <-- 공통으로 사용할 스크립트 들
         - Interface 폴더
         - core 폴더
         - Manager 폴더
         - 이니셜로 된 하위폴더를 만들어서 작업하기
    - 그 외는 큰 기능 단위로 먼저 묶은 다음 그 안에서 세부 기능으로 나눠주세요.  
    예시)  
    Player/  
 ┣ Movement/  
 ┣ Combat/  
 ┣ Jump/  
  - **SO (ScriptableObject) 폴더**
    - Scripts <-- 데이터를 만들기 위한  『스크립터블 오브젝트』 스크립트 보관용
    - Datas <--위에 데이터를 에셋으로 데이화 시켜 저장하는 폴더
  -  **Animaction   폴더**
      - 2D 캐릭터 또는 몬스터 애니메이션 및 기타등을 해당 폴더에서 관리한다. 
      - 관리하는 내용은 :Animator Controller,Animation Clip
      - 해당 폴더에서 데이터 관리시 연관성 있는 데이터 끼리 폴더 만들어서 그 폴더 내부에서 관리 바람  
     예시)  
     - PlayerAnimaction폴더  
       - 플레이어 애니메이션 클립 폴더
       - 애니메이션 컨트롤러
    
     - enemyAnimaction폴더
      - 몬스터 애니메이션 클립 폴더
      - 몬스터 애니메이션 컨트롤러
       
        


  - **Prefabs  폴더**  
 어떤 것들이 프리팹 될지 모르니깐   
알아볼수 있게 폴더 생성해서 잘 분리 하기.
이니셜로 된 하위폴더를 만들어서 작업하기
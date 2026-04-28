## 1. 네이밍 규칙 (필수)

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

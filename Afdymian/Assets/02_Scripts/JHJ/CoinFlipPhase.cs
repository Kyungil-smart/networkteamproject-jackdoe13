using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// MonoBehaviour가 아니라 PhaseState를 상속받도록 제작함
public class CoinFlipPhase : PhaseState 
{
    [Header("Coin UI")]
    [SerializeField] private Button _coinButton;

    private void Awake()
    {
        // 시작할 때 버튼에 클릭 이벤트 연결
        if (_coinButton != null)
        {
            _coinButton.onClick.AddListener(OnCoinClicked);
        }
    }

    protected override void Enter()
    {
        Debug.Log("--- 코인 돌입 ---");
        // 시작되면 코인을 누를 수 있게 활성화
        _coinButton.interactable = true; 
    }

    // 매 프레임 실행되는 곳 (지금은 비워둠)
    protected override void Update() { }

    // 코인을 클릭했을 때 실행
    private void OnCoinClicked()
    {
        _coinButton.interactable = false; // 연타 방지
        StartCoroutine(CoinResultRoutine());
    }

    // 연출 및 결과 도출
    private IEnumerator CoinResultRoutine()
    {
        Debug.Log("코인 굴러가는 중...");
        yield return new WaitForSeconds(1.0f); // 1초 대기 (연출 시간)

        // 랜덤으로 True(앞면/성공) 또는 False(뒷면/실패) 도출
        bool isSuccess = Random.Range(0, 2) == 0; 

        if (isSuccess)
            Debug.Log("결과: 앞면");
        else
            Debug.Log("결과: 뒷면");

        // 결과를 확인하게 1초 더 대기
        yield return new WaitForSeconds(1.0f);

        // 페이즈 종료 (매우 중요)
        // 부모 클래스인 PhaseState에 있는 함수
        // 이걸 부르면 TurnHandler가 알아서 다음 페이즈로 넘겨줌
        PhaseEnd(); 
    }

    protected override void Exit()
    {
        Debug.Log("--- 코인 종료 ---");
        // 필요하다면 여기서 버튼을 숨기거나 초기화
    }
}
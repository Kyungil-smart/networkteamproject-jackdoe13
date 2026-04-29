using UnityEngine;
using UnityEngine.InputSystem;

public class CoinClicker : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main; 
    }

    void Update()
    {
        // 마우스가 연결 확인, 왼쪽 버튼이 에셋을 눌렀는지 확인하기
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            PerformRaycast();
        }
    }

    private void PerformRaycast()
    {
        // 현재 마우스의 스크린에 어디있는지 가져오기
        Vector2 mouseScreenPosition = Mouse.current.position.ReadValue();

        // 해당 위치를 2d 좌표로 변환
        Vector2 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mouseScreenPosition);

        // 해당 월드 좌표에 레이캐스트를 발사
        RaycastHit2D hit = Physics2D.Raycast(mouseWorldPosition, Vector2.zero);

        // 레이캐스트 확인하기
        if (hit.collider != null)
        {
            // 에셋이 코인인지 태그 확인하기
            if (hit.collider.CompareTag("Coin"))
            {
                // 로그창에 결과 출력 -> 이후 값 뽑아내는 함수로 옮기기
                Debug.Log($"코인 클릭 확인: {hit.collider.gameObject.name}");
                
            }
        }
    }
}
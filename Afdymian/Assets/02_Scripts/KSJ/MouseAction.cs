using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseAction : MonoBehaviour
{
    [SerializeField] private InputActionAsset _inputActionAsset;
    [SerializeField] private Vector2 _mousePosition;
    [SerializeField] private Camera mainCamera;
    
    private InputSystem_Actions _inputActions;

    private void Awake()
    {
        _inputActions = new InputSystem_Actions();
    }

    private void OnEnable()
    { 
       _inputActions.Enable();
       _inputActions.Player.MouseLeftClick.started += PerformRaycast;
    }

    private void OnDisable()
    {
        _inputActions.Player.MouseLeftClick.started -= PerformRaycast;
        _inputActions.Disable();
    }

    private void PerformRaycast(InputAction.CallbackContext context)
    {
        _mousePosition = _inputActions.Player.MousePosition.ReadValue<Vector2>();
        
        // 현재 마우스의 스크린에 어디있는지 가져오기
        //Vector2 mouseScreenPosition = Mouse.current.position.ReadValue();

        // 해당 위치를 2d 좌표로 변환
        _mousePosition = mainCamera.ScreenToWorldPoint(_mousePosition);

        // 해당 월드 좌표에 레이캐스트를 발사
        RaycastHit2D hit = Physics2D.Raycast(_mousePosition, Vector2.zero);

        // 레이캐스트 확인하기
        if (hit.collider != null)
        {
                // 로그창에 결과 출력 -> 이후 값 뽑아내는 함수로 옮기기
               Debug.Log(hit.collider.gameObject.name);
        }
    }
}

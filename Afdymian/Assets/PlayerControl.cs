using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
   public void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        Debug.Log(input);
    }

   public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Fire 버튼 눌림");
        }
    }
}

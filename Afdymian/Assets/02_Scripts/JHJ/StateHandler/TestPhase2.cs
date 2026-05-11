using UnityEngine;

public class TestPhase2 : PhaseState
{
    protected override void Enter()
    {
        Debug.Log($"{gameObject.name}: Enter");
    }

    protected override void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TurnHandler.NextPhase();
        }
    }

    protected override void Exit()
    {
        Debug.Log($"{gameObject.name}: Exit");
    }
}
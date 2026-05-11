using System.Collections;
using UnityEngine;

public class TestPhase1 : PhaseState
{
    protected override void Enter()
    {
        StartCoroutine(SetStandby());
        Debug.Log($"{gameObject.name}: Enter");
    }

    protected override void Update()
    {
        if (!TurnHandler.IsStandby) return;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TurnHandler.NextPhase();
        }
    }

    protected override void Exit()
    {
        Debug.Log($"{gameObject.name}: Exit");
    }

    private IEnumerator SetStandby()
    {
        yield return new WaitForSeconds(2);
        TurnHandler.IsStandby = true;
        TurnHandler.StartCrountDown();
    }
}

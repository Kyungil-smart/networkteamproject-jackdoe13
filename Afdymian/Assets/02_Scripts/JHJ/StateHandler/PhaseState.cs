using UnityEngine;

public abstract class PhaseState : MonoBehaviour
{
    [Header("Config Text UI")]
    [SerializeField] protected float _uiActivateTime;
    [SerializeField] protected GameObject _phaseTextUI;

    [SerializeField] protected ulong _currentPlayerId;
    [SerializeField] protected TurnHandler TurnHandler;

    public void SetPlayer(ulong playerId)
    {
        _currentPlayerId = playerId;
        Debug.Log($"{gameObject.name} : SetPlayer {playerId}");
    }

    public void PhaseEnd() => TurnHandler.NextPhase();


    private void OnEnable() => Enter();
    private void OnDisable() => Exit();

    protected abstract void Enter();
    protected abstract void Update();
    protected abstract void Exit();
}

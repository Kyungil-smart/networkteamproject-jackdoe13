using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnHandler : MonoBehaviour // R&D 이후 NetworkBehaviour
{
    [SerializeField] private List<PhaseState> _phaseContainer = new();
    [SerializeField] private PhaseState _currentPhase;
    private int _currentPhaseIndex;

    [SerializeField] private List<ulong> _playerIdContainers = new();
    [SerializeField] private ulong _currentPlayerId;
    private int _currnetPlayerIndex;

    [SerializeField] private float _turnLimitTime;
    private WaitForSeconds _waitTurnTime;
    private WaitUntil _waitStandby;
    private Coroutine _turnControlerCoroutine;
    public bool IsStandby;

    private void Awake()
    {
        Init();
    }
    
    private void OnDestroy()
    {
        if (_turnControlerCoroutine != null)
        {
            StopCoroutine(_turnControlerCoroutine);
        }
    }

    private void Init()
    {
        _waitTurnTime = new WaitForSeconds(_turnLimitTime);
        _waitStandby = new WaitUntil(() => IsStandby);
        IsStandby = false;
        _turnControlerCoroutine = null;
    }
    
    public void NextPhase()
    {
        _currentPhase.gameObject.SetActive(false);
        _currentPhaseIndex++;

        if (_currentPhaseIndex == _phaseContainer.Count)
        {
            NextTurn();
            return;
        }

        _phaseContainer[_currentPhaseIndex].gameObject.SetActive(true);
        _currentPhase = _phaseContainer[_currentPhaseIndex];
    }

    public void NextTurn()
    {
        IsStandby = false;
        if(_turnControlerCoroutine != null) StopCoroutine(_turnControlerCoroutine);
        _currnetPlayerIndex++;
        _currnetPlayerIndex %= _playerIdContainers.Count;
        _currentPlayerId = _playerIdContainers[_currnetPlayerIndex];

        _currentPhase.gameObject.SetActive(false);
        _currentPhaseIndex = 0;
        _currentPhase = _phaseContainer[_currentPhaseIndex];
        _phaseContainer[_currentPhaseIndex].gameObject.SetActive(true);

        foreach (PhaseState phase in _phaseContainer)
        {
            phase.SetPlayer(_currentPlayerId);
        }
    }

    public void StartCrountDown()
    {
        if(_turnControlerCoroutine == null) StartCoroutine(WaitTurnTime());
    }

    public IEnumerator WaitTurnTime()
    {
        Debug.Log("Start Turn CountDown");
        yield return _waitTurnTime;
        NextTurn();
    }
}

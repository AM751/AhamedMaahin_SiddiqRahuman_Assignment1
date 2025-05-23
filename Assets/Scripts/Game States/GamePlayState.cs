using UnityEngine;
using UnityEngine.Events;

public class GamePlayState : MonoBehaviour, IState
{
    [SerializeField] private StateManager _gameStateManager;

    public UnityEvent OnEnterState;

    public UnityEvent OnUpdateState;

    public UnityEvent OnExitState;
    public void EnterState()
    {
        Debug.Log("Entering GamePlay state");
        Time.timeScale = 1;
        OnEnterState?.Invoke();
    }

    public void ExitState()
    {
        Debug.Log("Exiting the GamePlay state");
        Time.timeScale = 0;
        OnExitState?.Invoke();
    }

    public void UpdateState()
    {
        Debug.Log("Updating in the GamePlay sate");
        OnUpdateState?.Invoke();
    }

    public void GamePause()
    {
        _gameStateManager.ChangeState(_gameStateManager.gamePlayState);
    }
}

using UnityEngine;
using UnityEngine.Events;

public class GamePauseState : MonoBehaviour, IState
{
    [SerializeField] private StateManager _gameStateManager;

    public UnityEvent OnEnterState;

    public UnityEvent OnUpdateState;

    public UnityEvent OnExitState;
    public void EnterState()
    {
        Debug.Log("Entering GamePause state");
        Time.timeScale = 0;
        OnEnterState?.Invoke();
    }

    public void ExitState()
    {
        Debug.Log("Exiting the GamePause state");
        Time.timeScale = 1;
        OnExitState?.Invoke();
    }

    public void UpdateState()
    {
        Debug.Log("Updating in the GamePause sate");
        OnUpdateState?.Invoke();
    }

    public void ResumeGame()
    {
        _gameStateManager.ChangeState(_gameStateManager.gamePlayState);
    }
}

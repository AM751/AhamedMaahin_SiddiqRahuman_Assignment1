using UnityEngine;
using UnityEngine.Events;

public class GameOverState : MonoBehaviour, IState
{
    [SerializeField] private StateManager _gameStateManager;

    public UnityEvent OnEnterState;

    public UnityEvent OnUpdateState;

    public UnityEvent OnExitState;
    public void EnterState()
    {
        Debug.Log("Entering GameOver state");
        Time.timeScale = 0;
        OnEnterState?.Invoke();
    }

    public void ExitState()
    {
        Debug.Log("Exiting the GameOver state");
        OnExitState?.Invoke();
    }

    public void UpdateState()
    {
        Debug.Log("Updating in the GameOver sate");
        OnUpdateState?.Invoke();
    }

    public void MainMenu()
    {
        _gameStateManager.ChangeState(_gameStateManager.menuState);
    }
}

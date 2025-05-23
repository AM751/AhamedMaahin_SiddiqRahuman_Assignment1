using UnityEngine;
using UnityEngine.Events;

public class MenuState : MonoBehaviour, IState
{
    [SerializeField] private StateManager _gameStateManager;

    public UnityEvent OnEnterState;

    public UnityEvent OnUpdateState;

    public UnityEvent OnExitState;

    public void EnterState()
    {
        Debug.Log("Entering Menu state");
        OnEnterState?.Invoke();
    }

    public void ExitState()
    {
        Debug.Log("Exiting the menu state");
        OnExitState?.Invoke();
    }

    public void UpdateState()
    {
        Debug.Log("Updating in the menuu sate");
        OnUpdateState?.Invoke();
    }

    public void StartGame()
    {
        _gameStateManager.ChangeState(_gameStateManager.gamePlayState);
    }
}

using UnityEngine;

public class PlayerTerminalStrategy : IStrategy
{
    private PlayerStratManager _stratManager;

    public PlayerTerminalStrategy (PlayerStratManager Manager)
    {
        _stratManager = Manager;
    }
    public void Execute()
    {   
        if (_stratManager.ClickedTarget.GetType() != typeof(Terminal)) return;

        Debug.Log("Plaayer Interacting with the Terminal");
        _stratManager.mPlayerInteractor.Interact(_stratManager.ClickedTarget.targetObject.GetComponent<IInteractable>());
    }
}

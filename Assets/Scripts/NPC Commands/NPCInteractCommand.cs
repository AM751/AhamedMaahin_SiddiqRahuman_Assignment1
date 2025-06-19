using UnityEngine;

public class NPCInteractCommand : ICommand
{

    private bool _isComplete;
    public bool IsComplete => _isComplete;

    private IInteractable _targetInteractable;

    public NPCInteractCommand(IInteractable interactable)
    {
        _targetInteractable = interactable;
        _isComplete = false;
    }

    public void Execute()
    {
        if (!_isComplete)
        {
            _targetInteractable?.Interact();
            _isComplete = true;
        }
    }
}

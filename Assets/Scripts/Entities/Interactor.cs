using UnityEngine;

public class Interactor : MonoBehaviour
{
    private IInteractable _currentInteractable;

    private void OnTriggerEnter(Collider other)
    {
        _currentInteractable = other.gameObject.GetComponent<IInteractable>();
        if (_currentInteractable != null )
        {
            _currentInteractable.Interact();
        }
    }
}

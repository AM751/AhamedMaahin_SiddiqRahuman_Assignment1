using UnityEngine;

public class Terminal : MonoBehaviour, IInteractable, IClickable
{
    [SerializeField] private Renderer _renderer;

    public GameObject targetObject => gameObject;

    public void Interact()
    {
        _renderer.material.color = Random.ColorHSV();
    }

    public void OnClick(Vector3 clickPoint)
    {
        
    }
}

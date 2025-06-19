using UnityEngine;

public class Terminal : MonoBehaviour, IInteractable
{
    [SerializeField] private Renderer _renderer;
    public void Interact()
    {
        _renderer.material.color = Random.ColorHSV();
    }
}

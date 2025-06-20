using System;
using UnityEngine;

public class PlayerTerminalInteractor : MonoBehaviour
{
    //[SerializeField] private float maxInteractDistance = 5;


    public void Interact (IInteractable interactable)
    {
        interactable?.Interact();
    }

    internal void Interact(object clickedPoint)
    {
        throw new NotImplementedException();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

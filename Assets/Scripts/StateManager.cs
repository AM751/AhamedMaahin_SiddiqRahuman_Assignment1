using UnityEngine;

public class StateManager : MonoBehaviour
{

    private IState _currentState;

    public void ChangeState (IState newState)
    {
        //Check if there is a current state and if so, exit
        if (_currentState != null) _currentState.ExitState(); //(or) _currentState?.ExitState(); Both does the same thing.
        //Change the current state to the new state
        _currentState = newState;
        //Enter the new state
        _currentState.EnterState();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentState != null)
        {
            _currentState.UpdateState();
        }
        //other option to do this (No need for if statement for this kind of check): Both does the same thing.
        //_currentState?.UpdateState();
    }
}

using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.AI;

//With the help of constructors, The variables values can be declared..
public class NPCMoveToDestinationCommand : ICommand
{

    private bool _isComplete;
    public bool IsComplete => _isComplete;

    private NavMeshAgent _agent;
    private Vector3 _destination;
    private float _destinationCheckThreshold;

    private bool _isMoving;

    //Constructors to initiate the Values:

    public NPCMoveToDestinationCommand (NavMeshAgent currentAgent, Vector3 target, float destinatonCheck = 0.1f)
    {
        _agent = currentAgent;
        _destination = target;
        _destinationCheckThreshold = destinatonCheck;
        _isMoving = false;
        _isComplete = false;
    }

    public void Execute() /*This is an Update method for this code*/
    {
        if (_agent.remainingDistance <= _destinationCheckThreshold)
        {
            _isComplete = true;
        }

        if (!_isMoving && !_isComplete)
        {
            InitiateMovement();
        }
    }

    private void InitiateMovement()
    {
        _agent.destination = _destination;
        _isMoving = true;
    }
}

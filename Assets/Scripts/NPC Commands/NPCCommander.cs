using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCCommander : MonoBehaviour
{

    private ICommand _currentCommand;

    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private PatrollingPointsManager _pointsManager;
    [SerializeField] private float _defaultWaitTime = 5f;

    private Queue <ICommand> _commandQueue = new Queue <ICommand>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NPCMoveToDestinationCommand moveToFirstPoint = new NPCMoveToDestinationCommand(_agent, _pointsManager.GetRandomPatrolPoint());
        _commandQueue.Enqueue(moveToFirstPoint); ;

        NPCWaitCommand defaultWait = new NPCWaitCommand(_defaultWaitTime);
        _commandQueue.Enqueue(defaultWait);

        NPCMoveToDestinationCommand moveToSecondPoint = new NPCMoveToDestinationCommand(_agent, _pointsManager.GetRandomPatrolPoint());
        _commandQueue.Enqueue(moveToSecondPoint);
    }

    // Update is called once per frame
    void Update()
    {
        _currentCommand?.Execute();

        if (_currentCommand.IsComplete)
        {
            if (_commandQueue.Count > 0)

                _currentCommand = _commandQueue.Dequeue();

            else
                _currentCommand = null;

        }

    

    }
}

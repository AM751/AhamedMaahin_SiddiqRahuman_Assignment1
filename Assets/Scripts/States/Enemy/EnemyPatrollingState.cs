using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering.Universal;

public class EnemyPatrollingState : IState
{
    private EnemyStateMachine enemyStateMachine;

    public EnemyPatrollingState (EnemyStateMachine machine)
    {
        enemyStateMachine = machine;
    }

    private NavMeshAgent _navMeshAgent;

    private PatrollingPointsManager _patrollingPointsManager;

    private Vector3 _currentPatrolTarget;
    public void EnterState()
    {
        _navMeshAgent = enemyStateMachine.agent;
        _patrollingPointsManager = enemyStateMachine.PatrollingPointsManager;

        GetRandomPointAndMove();
    }

    public void ExitState()
    {
        
    }

    public void UpdateState()
    {
        Patrol();
        CheckForSuspiciousActivities();//Yet to be completed.
        CheckForPlayer(); //yet to be completed.
    }

    private void Patrol()
    {
        if (_navMeshAgent.remainingDistance <= .5f)
        {
            GetRandomPointAndMove();
        }
    }

    private void GetRandomPointAndMove()
    {
        _currentPatrolTarget = _patrollingPointsManager.GetRandomPatrolPoint();
        _navMeshAgent.SetDestination(_currentPatrolTarget);
    }

    private void CheckForSuspiciousActivities()
    {

    }

    public void CheckForPlayer()
    {

    }
}

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStateMachine : MonoBehaviour
{
    public EnemyPatrollingState enemyPatrollingState {  get; private set; }


    [SerializeField] private NavMeshAgent _agent;

    public NavMeshAgent agent => _agent;

    [SerializeField] private PatrollingPointsManager _patrollingPointsManager;

    public PatrollingPointsManager PatrollingPointsManager { get  { return _patrollingPointsManager; } }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private IState _currentState;

    public void ChangeState (IState nextState)
    {
        _currentState?.ExitState();
        _currentState = nextState;
        _currentState.EnterState();
    }
     void Awake()
     {
        enemyPatrollingState = new EnemyPatrollingState (this);

        ChangeState(enemyPatrollingState);
     }
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
    }
}

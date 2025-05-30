using UnityEngine;
using UnityEngine.AI;

public class PlayerMover : MonoBehaviour
{

    private PointAndClickManager _PointAndClickManager;

    private NavMeshAgent _agent; //Useful for AI navigation.

     void Awake()
     {
        //ServiceLocater asked to locate the Point and click manager:

        _PointAndClickManager = ServiceLocator.instance.GetService<PointAndClickManager>();
     }

     void OnEnable()
     {
        _PointAndClickManager.OnClicked += MovePlayer;
     }

     void OnDisable()
     {
        _PointAndClickManager.OnClicked -= MovePlayer;
     }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MovePlayer(Vector3 movePosition)
    {
        if (!_agent) return;

        _agent.destination = movePosition;
    }
}

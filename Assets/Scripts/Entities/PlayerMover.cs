using UnityEngine;
using UnityEngine.AI;

public class PlayerMover : MonoBehaviour
{

    private NavMeshAgent _agent; //Useful for AI navigation.

     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovePlayer(Vector3 movePosition)
    {
        if (!_agent) return;

        _agent.destination = movePosition;
    }
}

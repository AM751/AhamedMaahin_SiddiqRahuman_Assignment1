using UnityEngine;

public class PlayerBuilder : MonoBehaviour
{
    [SerializeField] private GameObject _buildPrefab;
    [SerializeField] private float _buildMaxDistance;

    public void Build (Vector3 buildPoint)
    {
        if (Vector3.Distance (transform.position, buildPoint) > _buildMaxDistance)
        {
            Debug.Log("Adei Pakkathla Engayachum Sollu daaa...");
            return;
        }
        var obj = Instantiate (_buildPrefab, buildPoint, Quaternion.identity);
        obj.transform.forward = transform.forward;
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

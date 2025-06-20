using UnityEngine;

public class Floor : MonoBehaviour, IClickable
{
    public GameObject targetObject => gameObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnClick(Vector3 clickPoint)
    {
        Debug.Log("Clicked");
    }
}

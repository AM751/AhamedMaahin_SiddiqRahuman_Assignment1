using UnityEngine;

public interface IClickable
{
    public GameObject targetObject { get; }
    public void OnClick(Vector3 clickPoint);


}

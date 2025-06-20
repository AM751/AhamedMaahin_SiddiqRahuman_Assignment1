using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClickManager : MonoBehaviour

{

    [SerializeField] private float maxRayDistnce;

    public event Action <Vector3, IClickable> OnClicked;

    private Camera _mainCamera;

    private RaycastHit hit;

     void Awake()
     {
        
        _mainCamera = Camera.main;
     }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_mainCamera) return; //If there is no main camera, it wont work.

        if (!Input.GetMouseButtonDown(0)) return;

        if (Physics.Raycast (_mainCamera.ScreenPointToRay(Input.mousePosition), out hit, maxRayDistnce))
        {
            IClickable clickable = hit.transform.GetComponent<IClickable>();
            if (clickable == null) return;
            clickable.OnClick(hit.point);
            OnClicked?.Invoke(hit.point, clickable);
        }
    }
}

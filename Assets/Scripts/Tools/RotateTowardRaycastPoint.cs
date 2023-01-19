using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardRaycastPoint : MonoBehaviour
{
    private Vector3 _targetPosition;
    [SerializeField] private float _turnSpeed = 3f;
    [SerializeField] LayerMask _layerMask;
    private void Start()
    {
        _targetPosition = transform.position;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100, _layerMask ))
            {
                _targetPosition = hit.point;
            }
            Vector3 rot = _targetPosition - transform.position;
            rot.y = 0;
            Quaternion targetRotation = Quaternion.LookRotation(rot);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, _turnSpeed * Time.deltaTime);
        }
    }
}

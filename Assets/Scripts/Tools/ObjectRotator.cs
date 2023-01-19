using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    private float rotXAxis;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float minDir;
    [SerializeField]
    private float maxDir;

    private float lastDirection;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RotateInYDirection();
        }   
    }
    public void RotateInYDirection()
    {
        if(Input.GetAxis("Mouse X")!=0)
        {
            lastDirection = Input.GetAxis("Mouse X");
        }
        
        rotXAxis += (lastDirection) * speed * Time.deltaTime;

        rotXAxis = ClampAngle(rotXAxis, minDir, maxDir);
        Quaternion toRotation = Quaternion.Euler(0, rotXAxis, 0);
        Quaternion rotation = toRotation;
        transform.rotation = rotation;
    }

    public float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float turnSpeed = 4.0f;  
    private float xRotate = 0.0f; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        
        float yRotate = transform.eulerAngles.y + yRotateSize;

       
        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);
        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
    }
}
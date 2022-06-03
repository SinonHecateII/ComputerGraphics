using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    private float xRotate = 0.0f;
    GameObject Sensitivity;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        Sensitivity = GameObject.FindGameObjectWithTag("Sensitivity");
    }

    // Update is called once per frame
    void Update()
    {
        pos = Sensitivity.transform.position;
        turnSpeed = pos.x;
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;

        float yRotate = transform.eulerAngles.y + yRotateSize;


        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);
        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
    }
}
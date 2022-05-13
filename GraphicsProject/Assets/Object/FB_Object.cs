using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FB_Object : MonoBehaviour
{
    public float startTime;
    public float minZ, maxZ;
    [Range(1, 100)]
    public float moveSpeed;

    public int sign = -1;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= startTime)
        {
            transform.position += new Vector3(0, 0, moveSpeed * Time.deltaTime * sign);

            if (transform.position.z <= minZ || transform.position.z >= maxZ)
            {
                sign *= -1;
            }
        }
    }
}


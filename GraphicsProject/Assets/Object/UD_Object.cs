using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UD_Object : MonoBehaviour
{
    public float startTime;
    public float minY, maxY;
    [Range(1, 100)]
    public float moveSpeed;

    public int sign = -1;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= startTime)
        {
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime * sign, 0);

            if (transform.position.y <= minY || transform.position.y >= maxY)
            {
                sign *= -1;
            }
        }
    }
}

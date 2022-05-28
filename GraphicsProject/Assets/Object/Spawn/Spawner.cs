using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject spawn_sphere;
    int SpawnObj;
    float currTime;
    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        SpawnPlay();
    }

    void SpawnPlay()
    {
        if(currTime > 5)
        {
            SpawnObj = 0;
            switch (SpawnObj)
            {
                case 0:
                    Instantiate(spawn_sphere, transform.position, Quaternion.identity);
                    currTime = 0;
                    break;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject == player)
        {
            cam2.SetActive(true);
            cam1.SetActive(false);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {

    }
}

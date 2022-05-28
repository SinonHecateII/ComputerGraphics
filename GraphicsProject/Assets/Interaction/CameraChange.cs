using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    GameObject player;
    GameObject spawn;
    GameObject ChangeArea;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawn = GameObject.FindGameObjectWithTag("SpawnPoint");
        ChangeArea = GameObject.FindGameObjectWithTag("ChangeButton");
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
            spawn.transform.position = ChangeArea.transform.position;

        }
    }

    private void OnTriggerExit(Collider other)
    {

    }
}

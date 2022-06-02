using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCode : MonoBehaviour
{
    GameObject player;
    public GameObject GoalCanvas;
    public GameObject cam1;
    public GameObject cam2;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == player) {
            GoalCanvas.SetActive(true);
            cam1.SetActive(true);
            cam2.SetActive(false);

            Invoke("Disable", 1.8f);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject == player) {
            GoalCanvas.SetActive(false);
        }
    }
    
    void Disable() { 
        GoalCanvas.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{

    GameObject player;
    GameObject spawn;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawn = GameObject.FindGameObjectWithTag("SpawnPoint");
    }

    //충돌 이벤트 발생
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)//충돌 대상이 플레이어 객체
        {
            player.transform.position = spawn.transform.position;  //플레이어가 죽을시 spawnpoint 오프젝트로 이동시킴
        }
    }

    //충돌이 끝나는 이벤트
    private void OnTriggerExit(Collider other)
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
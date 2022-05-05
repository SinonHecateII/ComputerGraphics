using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{

    GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    //충돌 이벤트 발생
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)//충돌 대상이 플레이어 객체
        {
            player.transform.position = Vector3.zero;//원점으로 이동
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
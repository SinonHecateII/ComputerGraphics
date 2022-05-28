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

    //�浹 �̺�Ʈ �߻�
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)//�浹 ����� �÷��̾� ��ü
        {
            player.transform.position = spawn.transform.position;  //�÷��̾ ������ spawnpoint ������Ʈ�� �̵���Ŵ
        }
    }

    //�浹�� ������ �̺�Ʈ
    private void OnTriggerExit(Collider other)
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
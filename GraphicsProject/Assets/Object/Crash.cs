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

    //�浹 �̺�Ʈ �߻�
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)//�浹 ����� �÷��̾� ��ü
        {
            player.transform.position = Vector3.zero;//�������� �̵�
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
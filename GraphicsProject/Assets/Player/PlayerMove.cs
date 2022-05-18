 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator animator;

    private Rigidbody rigid;

    public int JumpPower;
    public int MoveSpeed;

    private bool IsJumping;
    private bool Is2D = false;
    private bool IsChecked = false;

    void Start() {
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        IsJumping = false;
            }

    void Update() {
        Move();
        Jump();
        Check();
    }

    void Move() {
        if ((Input.GetKey(KeyCode.S) && Is2D == false) || (Is2D == true && Input.GetKey(KeyCode.A)))
        {  //캐릭터가 후방 이동시
            animator.SetBool("IsBack", true);
            animator.SetBool("IsJump", false);
            if (Is2D == false)
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");
                transform.Translate((new Vector3(h, 0, v) * MoveSpeed) * Time.deltaTime);
            }
            else
            {
                float v = Input.GetAxis("Horizontal");

                transform.Translate((new Vector3(0, 0, v) * MoveSpeed) * Time.deltaTime);
            }
        }
        else
        {
            animator.SetBool("IsBack", false);
        }

        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && (Is2D == false) || (Is2D == true && Input.GetKey(KeyCode.D)))  //캐릭터가 뒤를 제외한 모든 움직임
        {
            animator.SetBool("IsMoving", true);
            animator.SetBool("IsJump", false);
            if (Is2D == false)
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");
                transform.Translate((new Vector3(h, 0, v) * MoveSpeed) * Time.deltaTime);
            }
            else
            {
                float v = Input.GetAxis("Horizontal");

                transform.Translate((new Vector3(0, 0, v) * MoveSpeed) * Time.deltaTime);
            }
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }
    }

    void Check() {
        GameObject cam = GameObject.Find("SideCamera");
        if (cam.activeSelf == true && IsChecked == false) { 
            Debug.Log("화면 전환 입장");
            Is2D = true;
            IsChecked = true;
        }
    }

    void Jump() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (!IsJumping)
            {
                animator.SetBool("IsJump", true);
                IsJumping = true;
                rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
            }
            else {
                return;
            }
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Land")) {
            IsJumping = false;
            animator.SetBool("IsJump", false);
        }
    }
}
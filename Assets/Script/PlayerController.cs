using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;  // �������� �����������
    public float jumpForce = 5f; //���� ������
    private Rigidbody2D rb;        // ��������� Rigidbody2D
    public bool isGrounded; //��������� �� �������� �� �����
    private Animator anim; // ��������� Animator

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // �������� RigidBody 2D
        anim = GetComponent<Animator>(); // �������� Animator
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            anim.SetBool("jump",false); //������������ ������
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void Move()
    {
        float horiz = Input.GetAxis("Horizontal"); // �������� ���� � ����������
        rb.velocity = new Vector2(horiz * moveSpeed, rb.velocity.y); // �������� �������� �� ��� X
        //������������� �������� ����
        anim.SetBool("walk",horiz !=0); //������� ��������� ���� � Animator

        //������������ ��������� � ������� ��������
        if (horiz > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (horiz < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


    }


    private void Jump()
    {
        //������
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); //������
            anim.SetBool("jump",true); //���������� ������
        }
    }
}

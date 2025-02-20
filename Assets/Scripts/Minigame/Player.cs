using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    MiniGameManager miniGameManager = null;

    Animator animator = null;
    Rigidbody2D _rigidbody = null;


    public float jumpForce = 6f;
    public float forwardSpeed = 3f;
    public bool isDead = false;

    bool isJump = false;


    private void Awake()
    {
        isJump = false;
    }


    private void Start()
    {
        miniGameManager = MiniGameManager.Instance;
        
        
        animator = transform.GetComponent<Animator>();
        _rigidbody = transform.GetComponent<Rigidbody2D>();
        

        if (animator == null)
        {
            Debug.LogError("Not Founded Animator");
        }
        if (_rigidbody == null)
        {
            Debug.LogError("Not Founded Rigidbody");
        }
    }


    private void Update()
    {
        if (isDead)     // 죽었을 때
        {
            if (Input.GetMouseButtonDown(0))
            {
                //miniGameManager.Restart();      // temp
            }
        }
        else        // 스페이스를 눌렀고, 점프상태가 아니라면 점프
        {
            if (Input.GetKeyDown(KeyCode.Space) && !isJump)
                Jump();
        }
    }

    private void Jump()
    {
        isJump = true;
        _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        isJump = false;
    }





    public void FixedUpdate()
    {
        if (isDead) return;

        Vector3 velocity = _rigidbody.velocity;
        velocity.x = forwardSpeed;

        if (isJump)     // 점프상태일 때 점프 힘 받기
        {
            velocity.y += jumpForce;
            isJump = false;
        }

        _rigidbody.velocity = velocity;
    }



    public void OnCollisionEnter2D(Collision2D collision)       // obstacle과 충돌했을 때 죽기
    {
        if (isDead) return;

        if (collision.gameObject.CompareTag("Ground"))      // 땅은 충돌 제외
        {
            isJump = false;
            return;
        }

        animator.SetBool("IsDie", true);
        isDead = true;
        miniGameManager.GameOver();
    }
}
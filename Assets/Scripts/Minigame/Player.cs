using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator = null;
    Rigidbody2D _rigidbody = null;

    public float jumpForce = 6f;
    public float forwardSpeed = 3f;
    public bool isDead = false;

    bool isJump = false;


    private void Start()
    {
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
        if (isDead)
        {
            // 게임 재시작
            return;  // temp
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isJump = true;
            }
        }
    }


    public void FixedUpdate()
    {
        if (isDead) return;

        Vector3 velocity = _rigidbody.velocity;
        velocity.x = forwardSpeed;

        if (isJump)
        {
            velocity.y += jumpForce;
            velocity.y += jumpForce;
            isJump = false;
        }

        _rigidbody.velocity = velocity;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;

        animator.SetBool("IsDie", true);
        isDead = true;
    }
}

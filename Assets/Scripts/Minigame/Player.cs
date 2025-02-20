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
        if (isDead)
        {
            if (Input.GetMouseButtonDown(0))
            {
                miniGameManager.Restart();
            }
        }
        else
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

        if (isJump)
        {
            velocity.y += jumpForce;
            isJump = false;
        }

        _rigidbody.velocity = velocity;
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;

        if (collision.gameObject.CompareTag("Ground"))
        {
            isJump = false;
            return;
        }

        animator.SetBool("IsDie", true);
        isDead = true;
        miniGameManager.GameOver();
    }
}
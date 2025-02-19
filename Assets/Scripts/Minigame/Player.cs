using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator = null;
    Rigidbody2D _rigidbody = null;
    Transform playerTransform;

    public float jumpForce = 6f;
    public float forwardSpeed = 3f;
    public bool isDead = false;

    bool isJump = false;


    private void Start()
    {
        animator = transform.GetComponent<Animator>();
        _rigidbody = transform.GetComponent<Rigidbody2D>();
        playerTransform = transform.GetComponent<Transform>();

        
        //Vector2 minY = transform.localPosition;
        //minY.y = -1f;
        //transform.localPosition = minY;



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
            return; // temp
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
    }

    private void Jump()
    {
        _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
    }





    //public void FixedUpdate()
    //{
    //    if (isDead) return;

    //    Vector3 velocity = _rigidbody.velocity;
    //    velocity.x = forwardSpeed;

    //    if (isJump)
    //    {
    //        velocity.y += jumpForce;
    //        isJump = false;
    //    }

    //    _rigidbody.velocity = velocity;
    //}



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;

        if (collision.gameObject.CompareTag("Ground")) return;

        animator.SetBool("IsDie", true);
        isDead = true;
    }
}

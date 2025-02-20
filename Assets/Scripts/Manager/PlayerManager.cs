using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerManager : MonoBehaviour
{
    // ½Ì±ÛÅæ ¸¸µé¾î¾ß µÊ.  ´Ù¸¥¾À¿¡µµ ÀÖ´ÙÇÏ¸é ¾ø¾Ö¾ß µÊ




    private Rigidbody2D _rigidbody;

    private Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get { return moveDirection; } }

    private Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get { return lookDirection; } }

    [SerializeField] private SpriteRenderer mainCharacterRenderer;
    

    //private Camera camera;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }



    private void Start()
    {
        //// Ä«¸Þ¶ó
        //camera = Camera.main;


    }


    private void Update()
    {
        PlayerInput();
        Flip();
        
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
            Pause();
    }


    private void FixedUpdate()
    {
        Move(MoveDirection);
    }


    private void Flip()
    {
        if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            mainCharacterRenderer.flipX = true;
        }
        else
        {
            mainCharacterRenderer.flipX = false;
        }
    }

    private void Move(Vector2 direction)
    {
        direction = direction * 10;
        _rigidbody.velocity = direction;
    }

    private void Pause()        // ÇÃ·¹ÀÌ¾î µü ¸ØÃß°Ô. ±¸Çö ¾È µÆÀ½
    {
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            _rigidbody.velocity = Vector2.zero;
        }
    }


    private void PlayerInput()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        

        moveDirection = new Vector2(horizontal, vertical).normalized;
    }
}

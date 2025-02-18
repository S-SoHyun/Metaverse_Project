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
    

    private Camera camera;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }



    private void Start()
    {
        // Ä«¸Þ¶ó
        camera = Camera.main;


    }


    private void Update()
    {
        PlayerInput();
        Rotate(lookDirection);
    }


    private void FixedUpdate()
    {
        Move(MoveDirection);
    }


    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        bool isLeft = Mathf.Abs(rotZ) > 90f;

        mainCharacterRenderer.flipX = isLeft;


        // ¿þÆùÇÇ¹þ?
    }

    private void Move(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;
    }


    private void PlayerInput()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(horizontal, vertical).normalized;

        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);

        lookDirection = (worldPos - (Vector2)transform.position);
    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerManager : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get { return moveDirection; } }

    private Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get { return lookDirection; } }

    [SerializeField] private SpriteRenderer mainCharacterRenderer;
    [SerializeField] private bool test = true;

    private Camera camera;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }



    private void Start()
    {
        // 카메라
        camera = Camera.main;


    }


    private void Update()
    {
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


        // 웨폰피벗?
    }

    private void Move(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;
    }






}

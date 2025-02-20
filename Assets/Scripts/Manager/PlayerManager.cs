using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerManager : MonoBehaviour
{
    static PlayerManager playerManager;
    public static PlayerManager Instance { get { return playerManager; } }


    private Rigidbody2D _rigidbody;

    private Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get { return moveDirection; } }

    private Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get { return lookDirection; } }

    [SerializeField] private SpriteRenderer mainCharacterRenderer;
    

    private void Awake()
    {
        playerManager = this;
        _rigidbody = GetComponent<Rigidbody2D>();
    }



    private void Start()
    {

    }


    private void Update()
    {
        PlayerInput();
        Flip();
        
        //if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        //    Pause();
    }


    private void FixedUpdate()
    {
        Move(MoveDirection);
    }


    private void Flip()     // 왼쪽 방향키 누르면 flip
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

    private void Pause()        // 메인씬에서 플레이어 포지션이 -y가 됨. 구현 필요.
    {
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            _rigidbody.velocity = Vector2.zero;
        }
    }


    private void PlayerInput()          // 메인씬에서 방향키로 이동
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        

        moveDirection = new Vector2(horizontal, vertical).normalized;
    }
}

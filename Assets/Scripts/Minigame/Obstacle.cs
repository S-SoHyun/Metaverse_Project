using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    MiniGameManager miniGameManager;

    public float hightPosY = 1f;
    public float lowPosY = -0.73f;
    public Transform obstacle;
    public float widthPadding = 3f;

    public void Start()
    {
        miniGameManager = MiniGameManager.Instance;
    }

    
    public Vector2 SetRandomPlace(Vector2 lastPosition, int obstacleCount)      // 장애물 랜덤세팅
    {
        obstacle.localPosition = new Vector2(0, lowPosY);
        Vector2 placePosition = lastPosition + new Vector2(widthPadding, 0);

        transform.position = placePosition;

        return placePosition;
    }


    private void OnTriggerExit2D(Collider2D collision)      // Obstacled의 box collider 영역 나갈 때 점수 추가. 구현 X
    {
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            miniGameManager.AddScore(1);
        }
    }
}

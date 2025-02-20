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


    public Vector2 SetRandomPlace(Vector2 lastPosition, int obstacleCount)
    {
        obstacle.localPosition = new Vector2(0, lowPosY);
        
        Vector2 placePosition = lastPosition + new Vector2(widthPadding, 0);
        //placePosition.y = Random.Range(lowPosY, hightPosY);

        transform.position = placePosition;

        return placePosition;
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            miniGameManager.AddScore(1);
        }
    }



}

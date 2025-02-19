using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float hightPosY = 1f;
    public float lowPosY = -0.73f;
    public Transform obstacle;
    public float widthPadding = 3f;


    public Vector2 SetRandomPlace(Vector3 lastPosition, int obstacleCount)
    {
        obstacle.localPosition = new Vector2();
        
        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowPosY, hightPosY);

        transform.position = placePosition;

        return placePosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLooper : MonoBehaviour
{
    public int bgCount = 5;
    public int obstacleCount = 0;
    public Vector3 lastObstaclePos = Vector3.zero;


    private void Start()
    {
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>();

        lastObstaclePos = obstacles[0].transform.position;
        obstacleCount = obstacles.Length;

        for (int i = 0; i < obstacleCount; i++)
        {
            lastObstaclePos = obstacles[i].SetRandomPlace(lastObstaclePos, obstacleCount);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Background") || collision.CompareTag("Ground"))
        {
            float bgWidth = ((BoxCollider2D)collision).size.x;
            Vector3 pos = collision.transform.position;

            pos.x += bgWidth * bgCount;
            collision.transform.position = pos;
            return;
        }

        Obstacle obstacle = collision.GetComponent<Obstacle>();
        if (obstacle)
        {
            lastObstaclePos = obstacle.SetRandomPlace(lastObstaclePos, obstacleCount);
        }
    }
}

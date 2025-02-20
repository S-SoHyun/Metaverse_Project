using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLooper : MonoBehaviour
{
    public int bgCount = 5;
    public int obstacleCount = 0;
    public Vector3 lastObstaclePos = Vector3.zero;


    private void Start()        // 장애물 랜덤 세팅
    {
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>();

        lastObstaclePos = obstacles[0].transform.position;
        obstacleCount = obstacles.Length;

        for (int i = 0; i < obstacleCount; i++)
        {
            lastObstaclePos = obstacles[i].SetRandomPlace(lastObstaclePos, obstacleCount);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)         // BgLooper와 닿았을 때 배경, 장애물이 뒤로 가도록 세팅
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

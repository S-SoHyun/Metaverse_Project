using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveManager : MonoBehaviour
{
    static SceneMoveManager sceneMoveManager;
    public static SceneMoveManager Instance { get { return sceneMoveManager; } }


    private void Awake()
    {
        sceneMoveManager = this;
    }


    public void MoveMainScene()         // 메인씬으로 이동
    {
        SceneManager.LoadScene("MainScene");
    }

    private void OnCollisionEnter2D(Collision2D collision)      // 살롱 문에 충돌하면 미니게임씬으로 이동
    {
        SceneManager.LoadScene("MinigameScene");
    }
}

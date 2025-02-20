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


    public void MoveMainScene()         // ���ξ����� �̵�
    {
        SceneManager.LoadScene("MainScene");
    }

    private void OnCollisionEnter2D(Collision2D collision)      // ��� ���� �浹�ϸ� �̴ϰ��Ӿ����� �̵�
    {
        SceneManager.LoadScene("MinigameScene");
    }
}

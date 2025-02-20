using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveManager : MonoBehaviour
{
    public void MoveMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("MinigameScene");
    }
}

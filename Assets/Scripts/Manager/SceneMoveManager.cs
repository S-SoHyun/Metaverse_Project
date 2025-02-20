using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMoveManager : MonoBehaviour
{
    static SceneMoveManager instance;
    public static SceneMoveManager Instance {  get { return instance; } }


    private void Awake()
    {
        instance = this;
    }


    public void MoveMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("MinigameScene");
    }
}

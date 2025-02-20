using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    static MiniGameManager miniGameManager;
    public static MiniGameManager Instance { get { return miniGameManager; } }

    UIManager uiManager;


    private int currentScore = 0;
    public int CurrentScore { get => currentScore; }

    private int bestScore = 0;
    public int BestScore { get => bestScore; }

    private const string BestScoreKey = "BestScore";


    




    private void Awake()
    {
        miniGameManager = this;
        uiManager = FindObjectOfType<UIManager>();

        bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
    }


    private void Start()
    {
        GameStart();
    }


    void GameStart()        // ���� ����
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }






    public void Restart()      // ���� �����
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }



    public void GameOver()     // ���� ����
    {
       
        
    }


    void UpdateScore()
    {
        if (bestScore < currentScore)
        {
            bestScore = currentScore;
        }

        PlayerPrefs.SetInt(BestScoreKey, bestScore);
    }



    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
    }


    // ��ư
    public void OnClickStart()
    {
        miniGameManager.GameStart();
    }


    public void OnClickExit()
    {
        SceneMoveManager.Instance.MoveMainScene();
    }

}







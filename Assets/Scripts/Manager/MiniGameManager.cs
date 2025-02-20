using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    static MiniGameManager miniGameManager;
    public static MiniGameManager Instance { get { return miniGameManager; } }

    UIManager uiManager = null;
    //public UIManager UIManager { get { return uiManager; } }

    //public GameObject ruleUI;
    //public GameObject scoreUI;


    private int currentScore = 0;
    public int CurrentScore { get => currentScore; }

    private int bestScore = 0;
    public int BestScore { get => bestScore; }

    private const string BestScoreKey = "BestScore";

    //Player player;

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


    private void Update()
    {
        //if (isDead)
        //{
        //    GameOver();
        //}
        //else
        //    UIManager.Instance.UpdateScore();
        //return;
       




    }



    public void GameStart()  
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //ruleUI 갖고오기?
    }


    public void AddScore(int score)
    {
        currentScore += score;
        //UIManager.Instance.UpdateScore();
    }


    void UpdateScore()
    {
        if (bestScore < currentScore)
        {
            bestScore = currentScore;
        }

        PlayerPrefs.SetInt(BestScoreKey, bestScore);
    }








    // 게임오버 됐을 경우
    public void GameOver()
    {
        UpdateScore();
        //UIManager.Instance.SetScoreUI();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour        // 구현 안 된 거 多
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


    void GameStart()        // 게임 시작, 재시작
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void GameOver()     // 게임 오버
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



    public void AddScore(int score)       // 점수 +
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
    }


    // 버튼 관련
    public void OnClickStart()
    {
        miniGameManager.GameStart();
    }


    public void OnClickExit()
    {
        SceneMoveManager.Instance.MoveMainScene();
    }

}







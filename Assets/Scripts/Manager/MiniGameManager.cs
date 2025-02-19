using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    static MiniGameManager miniGameManager;
    public static MiniGameManager Instance { get { return miniGameManager; } }

    UIManager uiManager;
    public UIManager UIManager { get { return uiManager; } }

    public GameObject ruleUI;


    private int currentScore = 0;
    private int bestScore = 0;
    public int BestScore { get => bestScore; }

    private const string BestScoreKey = "BestScore";

    Player player;
    

    private void Awake()
    {
        miniGameManager = this;
        uiManager = FindObjectOfType<UIManager>();
        ruleUI = GetComponent<GameObject>();
    }


    //  ----------------------------------------- //

    private void Start()
    {
        Time.timeScale = 0f;
        uiManager.ruleUI.SetActive(true);
      

        bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
    }

    // 1. 시간이 멈추고 룰UI가 보이게 해야 됨
    // 2. 룰UI에 있는 스타트 버튼을 누르면 시간이 흐르면서 게임이 시작돼야 함
    // 3. 플레이어는 열심히 게임

    // 4. 죽어야 하는 상황이라면 시간을 멈추고 점수UI가 나와야 됨
    // 5. 리스타트 버튼을 눌렀다면 다시 룰UI를 보여주고 시간 정지
    // 6. 나가기를 눌렀다면 메인씬으로 이동

    private void Update()
    {
        //if (player.isDead)
        //{
        //    GameOver();
        //}
    }







    private void GameStart()           // 1. 시간이 멈추고 룰UI가 보이게 해야 됨
    {
        Time.timeScale = 1f;
        uiManager.ruleUI.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
   


    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
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
        Time.timeScale = 0f;
        uiManager.scoreUI.SetActive(true);
        UpdateScore();
    }






    // RuleUI, ScoreUI에 쓸 리스타트 버튼과 나가기 버튼
    public void RestartBtn()    // 게임 스타트
    {
        GameStart();
    }

    public void ExitBtn()       // 메인씬으로 나가기
    {
        SceneManager.LoadScene("MainScene");
    }
}

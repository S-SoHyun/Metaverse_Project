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

    // 1. �ð��� ���߰� ��UI�� ���̰� �ؾ� ��
    // 2. ��UI�� �ִ� ��ŸƮ ��ư�� ������ �ð��� �帣�鼭 ������ ���۵ž� ��
    // 3. �÷��̾�� ������ ����

    // 4. �׾�� �ϴ� ��Ȳ�̶�� �ð��� ���߰� ����UI�� ���;� ��
    // 5. ����ŸƮ ��ư�� �����ٸ� �ٽ� ��UI�� �����ְ� �ð� ����
    // 6. �����⸦ �����ٸ� ���ξ����� �̵�

    private void Update()
    {
        //if (player.isDead)
        //{
        //    GameOver();
        //}
    }







    private void GameStart()           // 1. �ð��� ���߰� ��UI�� ���̰� �ؾ� ��
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








    // ���ӿ��� ���� ���
    public void GameOver()
    {
        Time.timeScale = 0f;
        uiManager.scoreUI.SetActive(true);
        UpdateScore();
    }






    // RuleUI, ScoreUI�� �� ����ŸƮ ��ư�� ������ ��ư
    public void RestartBtn()    // ���� ��ŸƮ
    {
        GameStart();
    }

    public void ExitBtn()       // ���ξ����� ������
    {
        SceneManager.LoadScene("MainScene");
    }
}

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


    private int currentScore = 0;

    private void Awake()
    {
        miniGameManager = this;
        uiManager = FindObjectOfType<UIManager>();
    }


    private void Start()
    {
        uiManager.UpdateScore(0);
    }


    void GameStart()        // 게임 시작
    {

    }






    public void Restart()      // 게임 재시작
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    public void GameOver()     // 게임 오버
    {
        // 최종 점수 UI창 뜨게 하기
        // 유저가 EXIT 버튼을 클릭한다면 미니게임 할 수 있는 살룸창으로 돌아가기
        // 유저가 Restart 버튼을 클릭한다면 다시 미니게임이 재시작하도록 하기


        Debug.Log("게임 오버");
        //Restart();
    }


    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
    }

}

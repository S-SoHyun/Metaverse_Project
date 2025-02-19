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


    void GameStart()        // ���� ����
    {

    }






    public void Restart()      // ���� �����
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    public void GameOver()     // ���� ����
    {
        // ���� ���� UIâ �߰� �ϱ�
        // ������ EXIT ��ư�� Ŭ���Ѵٸ� �̴ϰ��� �� �� �ִ� ���â���� ���ư���
        // ������ Restart ��ư�� Ŭ���Ѵٸ� �ٽ� �̴ϰ����� ������ϵ��� �ϱ�


        Debug.Log("���� ����");
        //Restart();
    }


    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
    }

}

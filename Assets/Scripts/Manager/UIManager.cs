using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    //public GameObject ruleUI;

    MiniGameManager miniGameManager;

    private void Awake()
    {
        instance = this;
        miniGameManager = FindObjectOfType<MiniGameManager>();
        //ruleUI = transform.Find("RuleUI").GetComponent<GameObject>();
    }


   
    



    // ¹öÆ°
    public void OnClickStart()
    {
        miniGameManager.GameStart();
    }

    //public void OnClickRestart()
    //{
        
    //}


    public void OnClickExit()
    {
        SceneMoveManager.Instance.MoveMainScene();
    }

}

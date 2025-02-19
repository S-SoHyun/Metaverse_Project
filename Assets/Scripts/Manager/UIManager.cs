using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    static UIManager instance;
    public static UIManager Instance { get { return Instance; } }

    public GameObject ruleUI;
    public GameObject scoreUI;

    public TextMeshProUGUI scoreTxt;



    private void Awake()
    {
        scoreTxt = GetComponent<TextMeshProUGUI>();
        ruleUI = GetComponent<GameObject>();
        scoreUI = GetComponent<GameObject>();

    }


  





    
    public void Start()
    {
        
    }


    public void UpdateScore(int score)
    {
        scoreTxt.text = score.ToString();
    }
}

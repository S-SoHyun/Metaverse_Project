using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;     // ½Ì±ÛÅæ ¼±¾ð
   
    UIManager uiManager;

    public UIManager UIManager {  get { return uiManager; } }


    private void Awake()
    {
        Instance = this;
        uiManager = FindObjectOfType<UIManager>();
    }
}

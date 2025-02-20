using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;     // �̱��� ����
   
    UIManager uiManager;

    public UIManager UIManager {  get { return uiManager; } }


    private void Awake()
    {
        Instance = this;
        uiManager = FindObjectOfType<UIManager>();
    }
}

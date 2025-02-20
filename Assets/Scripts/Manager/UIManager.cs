using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void Start()
    {
        if (scoreText == null)
        {
            Debug.LogError("scoreText is null");
        }
    }


    public void UpdateScore(int score)      // ����UI�� ���� �ݿ�
    {
        scoreText.text = score.ToString();
    }
}

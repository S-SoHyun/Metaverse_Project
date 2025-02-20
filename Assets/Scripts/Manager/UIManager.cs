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


    public void UpdateScore(int score)      // 점수UI에 점수 반영
    {
        scoreText.text = score.ToString();
    }
}

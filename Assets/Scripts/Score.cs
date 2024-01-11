using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    [SerializeField]
    Ball_Behaviour ball;
    int Scorepoints;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;
    public void ResetScore()
    
    {
        Scorepoints = 0;
        UpdateScoreText();
    }
    public void Blue_hit()
    {
        Scorepoints += 10;
        UpdateScoreText();
    }
    public void Green_hit()
    {
        Scorepoints += 20;
        UpdateScoreText();
    }
    public void Orange_hit()
    {
        Scorepoints += 30;
        UpdateScoreText();
    }
    public void Pink_hit()
    {
        Scorepoints += 40;
        UpdateScoreText();
    }
    public void Red_hit()
    {
        Scorepoints += 50;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = Scorepoints.ToString("0000");
        lifeText.text = "Vidas : " + ball.lifes.ToString();
    }
}

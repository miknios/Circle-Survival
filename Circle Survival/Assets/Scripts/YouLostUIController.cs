using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouLostUIController : MonoBehaviour
{
    public Text YouLostText;
    public Text ScoreText;
    public Text HighScoreText;

    private void Awake()
    {
        HideYouLostScreen();
    }

    public void SetScore(int score)
    {
        ScoreText.text = "Score: " + score;
    }

    public void HideYouLostScreen()
    {
        YouLostText.enabled = false;
        ScoreText.enabled = false;
        HighScoreText.enabled = false;
    }

    public void ShowYouLostScreen(bool isHighScore)
    {
        YouLostText.enabled = true;
        ScoreText.enabled = true;
        HighScoreText.enabled = isHighScore;
    }
}

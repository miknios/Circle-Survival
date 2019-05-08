using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    GameManager gameManager;
    float scoreTimer = 0;
    public int Score;
    public Text scoreText;

    private void Awake()
    {
        gameManager = GetComponent<GameManager>();
    }

    void Update()
    {
        if (gameManager.GameRunning) {
            scoreTimer += Time.deltaTime;
            if (scoreTimer >= 1)
            {
                scoreTimer = 0;
                Score++;
                scoreText.text = Score.ToString();
            }
        }
    }

    //TODO
    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("highscore");
    }

    //TODO
    public void SaveHighScore()
    {
        if (IsHighScore())
            PlayerPrefs.SetInt("highscore", Score);
        PlayerPrefs.Save();
    }

    public bool IsHighScore()
    {
        return Score > GetHighScore();
    }
}

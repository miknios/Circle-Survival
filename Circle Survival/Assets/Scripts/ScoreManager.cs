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
        if (gameManager.GameOn) {
            scoreTimer += Time.deltaTime;
            if (scoreTimer >= 1)
            {
                scoreTimer = 0;
                Score++;
                scoreText.text = Score.ToString();
            }
        }
    }
}

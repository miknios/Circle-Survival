using UnityEngine;
using UnityEngine.UI;

public class YouLostUIController : MonoBehaviour
{
    public Text YouLostText;
    public Text ScoreText;
    public Text HighScoreText;

    public IntVariable Score;
    public IntVariable HighScore;

    private void Awake()
    {
        HideYouLostScreen();
    }

    public void SetScore()
    {
        ScoreText.text = "Score: " + Score.Value;
    }

    public void HideYouLostScreen()
    {
        YouLostText.enabled = false;
        ScoreText.enabled = false;
        HighScoreText.enabled = false;
    }

    public void ShowYouLostScreen()
    {
        YouLostText.enabled = true;
        ScoreText.enabled = true;
        HighScoreText.enabled = Score.Value > HighScore.Value;
    }
}

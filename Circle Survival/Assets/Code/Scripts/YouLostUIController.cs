using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class YouLostUIController : MonoBehaviour
{
    public TextMeshProUGUI YouLostText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HighScoreText;

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

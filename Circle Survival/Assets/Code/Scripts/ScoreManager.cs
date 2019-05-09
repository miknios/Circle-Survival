using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameEvent ScoreChangeEvent;
    public FloatVariable Timer;
    public IntVariable Score;
    public IntVariable HighScore;

    private void Start()
    {
        HighScore.Value = GetHighScore();
    }

    void Update()
    {
        if ((int)Timer.Value > Score.Value)
        {
            Score.Value++;
            ScoreChangeEvent.Raise();
        }
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("highscore");
    }

    public void SaveHighScore()
    {
        if (Score.Value > GetHighScore())
        {
            HighScore.Value = Score.Value;
            PlayerPrefs.SetInt("highscore", Score.Value);
            PlayerPrefs.Save();
        }
    }

    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("highscore", 0);
    }
}

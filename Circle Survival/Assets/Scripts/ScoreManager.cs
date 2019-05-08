using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameEvent ScoreChangeEvent;
    public FloatVariable Timer;
    public IntVariable Score;
    public BoolVariable IsHighScore;

    void Update()
    {
        if ((int)Timer.Value > Score.Value)
        {
            Score.Value++;
            CalculateHighScore();
            ScoreChangeEvent.Raise();
        }
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("highscore");
    }

    public void SaveHighScore()
    {
        if (IsHighScore.Value)
        {
            PlayerPrefs.SetInt("highscore", Score.Value);
            PlayerPrefs.Save();
        }
    }

    public void CalculateHighScore()
    {
        IsHighScore.Value = Score.Value > GetHighScore();
    }
}

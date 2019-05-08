using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameRunning;

    public FloatVariable Timer;
    public IntVariable Score;
    public BoolVariable IsHighScore;
    public GameParameters InitialParameters;
    public GameParameters Parameters;
    public GameEvent GameStartEvent;
    public GameEvent GameEndEvent;
    public GameEvent CountdownEndEvent;

    private void Awake()
    {
        Parameters.MinExplodeTime = InitialParameters.MinExplodeTime;
        Parameters.MaxExplodeTime = InitialParameters.MaxExplodeTime;
        Parameters.SpawnTime = InitialParameters.SpawnTime;
        IsHighScore.Value = false;
        Score.Value = 0;
        Timer.Value = 0;
    }

    void Update()
    {
        if (gameRunning)
        {
            Timer.Value += Time.deltaTime;
        }
    }

    public void UpdateSpawnAndExplodeTimes()
    {
        Parameters.MinExplodeTime = (float)GetDiffCurveVal(InitialParameters.MinExplodeTime, 0.5f, Score.Value);
        Parameters.MaxExplodeTime = (float)GetDiffCurveVal(InitialParameters.MaxExplodeTime, 1f, Score.Value);
        Parameters.SpawnTime = (float)GetDiffCurveVal(InitialParameters.SpawnTime, 0.3f, Score.Value);
    }

    public void StartGame()
    {
        gameRunning = true;
        GameStartEvent.Raise();
    }

    public void EndGame()
    {
        if (gameRunning)
        {
            gameRunning = false;
            GameEndEvent.Raise();
        }
    }

    //TODO zbalansowac wykres trudnosci -- teraz chyba za szybko rosnie na samym poczatku
    public static double GetDiffCurveVal(double initVal, double minVal, double x)
    {
        double a = initVal - minVal;
        return initVal - (a - a / Math.Pow(x, 1.2));
    }
}

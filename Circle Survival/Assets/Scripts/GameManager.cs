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
            UpdateSpawnAndExplodeTimes();
        }
    }

    private void UpdateSpawnAndExplodeTimes()
    {
        
        if((int)Timer.Value % 2 == 0)
        {
            Parameters.MinExplodeTime = (float)GetDiffCurveVal(InitialParameters.MinExplodeTime, 0.5f, Timer.Value);
            Parameters.MaxExplodeTime = (float)GetDiffCurveVal(InitialParameters.MaxExplodeTime, 1f, Timer.Value);
            Parameters.SpawnTime = (float)GetDiffCurveVal(InitialParameters.SpawnTime, 0.3f, Timer.Value);
        }
    }

    //TODO zbalansowac wykres trudnosci -- teraz chyba za szybko rosnie na samym poczatku
    public static double GetDiffCurveVal(double initVal, double minVal, double x)
    {
        double a = initVal - minVal;
        return initVal - (a - a / Math.Pow(x, 1.0d / 5.0d));
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
}

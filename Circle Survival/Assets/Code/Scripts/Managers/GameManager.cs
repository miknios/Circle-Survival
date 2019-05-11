using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameRunning;

    public FloatVariable Timer;
    public IntVariable Score;
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

    public void StartGame()
    {
        if (!gameRunning)
        {
            gameRunning = true;
            GameStartEvent.Raise();
        }
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

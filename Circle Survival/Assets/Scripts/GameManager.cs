using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputController))]
[RequireComponent(typeof(ScoreManager))]
[RequireComponent(typeof(SpawnManager))]
[RequireComponent(typeof(BombPool))]
public class GameManager : MonoBehaviour
{
    //game initial parameters
    public float InitMinExplodeTime = 2;
    public float InitMaxExplodeTime = 4;
    public float InitSpawnTime = 1;
    public int CountdownTime = 3;

    public float MinExplodeTime;
    public float MaxExplodeTime;
    public float SpawnTime;
    public bool GameRunning;
    public float timer;

    SpawnManager spawnManager;
    InputController inputController;
    public ScoreManager scoreManager;

    private void Awake()
    {
        spawnManager = GetComponent<SpawnManager>();
        inputController = GetComponent<InputController>();
        scoreManager = GetComponent<ScoreManager>();
        MinExplodeTime = InitMinExplodeTime;
        MaxExplodeTime = InitMaxExplodeTime;
        SpawnTime = InitSpawnTime;
        GameRunning = false;
    }

    void Update()
    {
        if (GameRunning)
        {
            UpdateSpawnAndExplodeTimes();
        }
    }

    private void UpdateSpawnAndExplodeTimes()
    {
        timer += Time.deltaTime;
        if((int)timer % 2 == 0)
        {
            //TODO uzaleznic kompletnie funkcje od wartosci poczatkowych
            //MinExplodeTime = (float)(InitMinExplodeTime - (2.0d - 2.0d / Math.Pow(timer, 1.0d / 4.0d)));
            //MaxExplodeTime = (float)(InitMaxExplodeTime - (3.0d - 3.0d / Math.Pow(timer, 1.0d / 4.0d)));
            //SpawnTime =      (float)(InitSpawnTime - (0.7d - 0.7d / Math.Pow(timer, 1.0d / 4.0d)));
            MinExplodeTime = (float)GetDiffCurveVal(InitMinExplodeTime, 0.5f, timer);
            MaxExplodeTime = (float)GetDiffCurveVal(InitMaxExplodeTime, 1f, timer);
            SpawnTime = (float)GetDiffCurveVal(InitSpawnTime, 0.3f, timer);
        }
    }

    public static double GetDiffCurveVal(double initVal, double minVal, double x)
    {
        double a = initVal - minVal;
        return initVal - (a - a / Math.Pow(x, 1.0d / 3.0d));
    }

    public void StartGame()
    {
        GameRunning = true;
    }

    public void EndGame()
    {
        GameRunning = false;
        //TODO tu wywolanie ekranu przegranej
    }
}

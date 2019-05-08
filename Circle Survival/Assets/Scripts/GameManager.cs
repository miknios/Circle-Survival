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
    public float timer = 1;

    SpawnManager spawnManager;
    InputController inputController;
    public ScoreManager scoreManager;
    public YouLostUIController youLostManager;

    private void Awake()
    {
        spawnManager = GetComponent<SpawnManager>();
        inputController = GetComponent<InputController>();
        scoreManager = GetComponent<ScoreManager>();
        youLostManager = FindObjectOfType<YouLostUIController>();
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
            MinExplodeTime = (float)GetDiffCurveVal(InitMinExplodeTime, 0.5f, timer);
            MaxExplodeTime = (float)GetDiffCurveVal(InitMaxExplodeTime, 1f, timer);
            SpawnTime = (float)GetDiffCurveVal(InitSpawnTime, 0.3f, timer);
        }
    }

    //TODO zbalansowac wykres trudnosci -- teraz chyba za szybko rosnie na samym poczatku
    public static double GetDiffCurveVal(double initVal, double minVal, double x)
    {
        double a = initVal - minVal;
        return initVal - (a - a / Math.Pow(x, 1.0d / 4.0d));
    }

    public void StartGame()
    {
        GameRunning = true;
    }

    public void EndGame()
    {
        GameRunning = false;
        //TODO tu wywolanie ekranu przegranej
        scoreManager.scoreText.text = "";
        youLostManager.SetScore(scoreManager.Score);
        youLostManager.ShowYouLostScreen(scoreManager.IsHighScore());
        scoreManager.SaveHighScore();
    }
}

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
        UpdateSpawnAndExplodeTimes();
    }

    private void UpdateSpawnAndExplodeTimes()
    {
        //TODO ZROBIC TOOOO


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

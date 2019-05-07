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
    [SerializeField]
    float InitMinExplodeTime = 2;
    [SerializeField]
    float InitMaxExplodeTime = 4;
    [SerializeField]
    float InitSpawnTime = 1;
    public int countdownTime = 3;

    public float MinExplodeTime;
    public float MaxExplodeTime;
    public float SpawnTime;
    public bool GameOn;

    public float timer;
    SpawnManager spawnManager;
    InputController inputController;
    ScoreManager scoreManager;

    private void Awake()
    {
        spawnManager = GetComponent<SpawnManager>();
        inputController = GetComponent<InputController>();
        scoreManager = GetComponent<ScoreManager>();
        MinExplodeTime = InitMinExplodeTime;
        MaxExplodeTime = InitMaxExplodeTime;
        SpawnTime = InitSpawnTime;
        spawnManager.enabled = false;
        inputController.enabled = false;
        GameOn = false;
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
        spawnManager.enabled = true;
        inputController.enabled = true;
        GameOn = true;
    }

    public void EndGame()
    {
        spawnManager.enabled = false;
        inputController.enabled = false;
        GameOn = false;
        //TODO tu wywolanie ekranu przegranej
    }
}

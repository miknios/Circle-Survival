using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    float spawnTimer = 0;
    GameManager gameManager;
    BombPool bombPool;

    private void Start()
    {
        gameManager = GetComponent<GameManager>();
        bombPool = GetComponent<BombPool>();
    }

    void Update()
    {
        if (gameManager.GameRunning)
        {
            spawnTimer += Time.deltaTime;
            if(spawnTimer > gameManager.SpawnTime)
            {
                spawnTimer = 0;
                SpawnBomb();
            }
        }
    }

    private void SpawnBomb()
    {
        BombPool.Bombs whichBomb = UnityEngine.Random.Range(0f, 1f) > 0.1 ? 
            BombPool.Bombs.GREEN : BombPool.Bombs.BLACK;
        GameObject bombToSpawn = bombPool.Get(whichBomb);
        if (bombToSpawn == null)
            return;
        float xPos;
        float yPos;
        float explodeTime = UnityEngine.Random.Range(gameManager.MinExplodeTime, gameManager.MaxExplodeTime);
        bool spaceClear;
        do
        {
            xPos = UnityEngine.Random.Range(
                Camera.main.ScreenToWorldPoint(Vector2.zero).x + 0.5f, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x - 0.5f
                );
            yPos = UnityEngine.Random.Range(
                Camera.main.ScreenToWorldPoint(Vector2.zero).y + 0.5f, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y - 0.5f
                );
            spaceClear = Physics2D.OverlapCircle(new Vector2(xPos, yPos), 0.5f, 1 << 8) == null;
        } while (!spaceClear);

        bombToSpawn.transform.position = new Vector2(xPos, yPos);
        bombToSpawn.GetComponent<BombController>().explodeTime = explodeTime;
        bombToSpawn.SetActive(true);
    }
}

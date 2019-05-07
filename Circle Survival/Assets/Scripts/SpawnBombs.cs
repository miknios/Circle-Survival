using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBombs : MonoBehaviour
{
    [SerializeField]
    GameObject greenBombPrefab;
    [SerializeField]
    GameObject blackBombPrefab;
    [SerializeField]
    float minExplodeTime = 2;
    [SerializeField]
    float maxExplodeTime = 4;
    [SerializeField]
    float spawnTime = 1;
    [SerializeField]
    float spawnTimer;

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer > spawnTime)
        {
            spawnTimer = 0;
            SpawnBomb();
        }
    }

    private void SpawnBomb()
    {
        GameObject bombToInst = UnityEngine.Random.Range(0f, 1f) > 0.1 ? 
            greenBombPrefab : blackBombPrefab;
        float xPos;
        float yPos;
        float explodeTime = UnityEngine.Random.Range(minExplodeTime, maxExplodeTime);
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

        bombToInst.GetComponent<BombBehaviour>().explodeTime = explodeTime;
        Instantiate(bombToInst, new Vector3(xPos, yPos), Quaternion.identity);
    }
}

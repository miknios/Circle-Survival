using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    float timer;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > spawnTime)
        {
            timer = 0;
            SpawnBomb();
        }
    }

    private void SpawnBomb()
    {
        float bombRandNum = UnityEngine.Random.Range(0f, 1f);
        GameObject bombToInst = bombRandNum > 0.1 ? 
            greenBombPrefab : blackBombPrefab;
        Instantiate(bombToInst);
        if(bombToInst == greenBombPrefab)
        {
            bombToInst.GetComponent<GreenBombBehaviour>().explodeTime = 
                UnityEngine.Random.Range(minExplodeTime, maxExplodeTime);
        }
        else
        {
            bombToInst.GetComponent<BlackBombBehaviour>().explodeTime =
                UnityEngine.Random.Range(minExplodeTime, maxExplodeTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pool
{
    public GameObject prefab;
    public int poolSize;
    public GameObject[] objects;
}

public class BombPool : MonoBehaviour
{
    public enum Bombs {
        GREEN = 0, BLACK = 1
    };

    public Pool[] pools;

    void Start()
    {
        foreach(Pool pool in pools)
        {
            GameObject[] newObjects = new GameObject[pool.poolSize];
            for(int i = 0; i < pool.poolSize; i++)
            {
                GameObject newBomb = Instantiate(pool.prefab);
                newBomb.SetActive(false);
                newObjects[i] = newBomb;
            }
            pool.objects = newObjects;
        }
    }

    public GameObject Get(Bombs bombs)
    {
        GameObject[] gameObjects = pools[(int)bombs].objects;

        foreach(GameObject bomb in gameObjects)
        {
            if (!bomb.activeInHierarchy)
            {
                return bomb;
            }
        }

        return null;
    }


}



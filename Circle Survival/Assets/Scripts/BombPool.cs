using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pool
{
    public GameObject prefab;
    public int poolSize;
    public List<GameObject> objectList;
}

public class BombPool : MonoBehaviour
{
    public enum Bombs {
        GREEN = 0, BLACK = 1
    };

    public Pool[] pools;

    void Start()
    {
        for(int i = 0; i < pools.Length; i++)
        {
            var newList = new List<GameObject>();
            for(int j = 0; j < pools[i].poolSize; j++)
            {
                GameObject newBomb = Instantiate(pools[i].prefab);
                newBomb.SetActive(false);
                newList.Add(newBomb);
            }
            pools[i].objectList = newList;
        }
    }

    public GameObject Get(Bombs bombs)
    {
        List<GameObject> bombPool = pools[(int)bombs].objectList;

        foreach(GameObject bomb in bombPool)
        {
            if (!bomb.activeInHierarchy)
            {
                return bomb;
            }
        }

        return null;
    }


}



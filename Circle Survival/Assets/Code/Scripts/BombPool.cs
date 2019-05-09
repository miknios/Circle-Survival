using UnityEngine;

[System.Serializable]
public class Pool
{
    public GameObject Prefab;
    public int PoolSize;
    public GameObject[] GameObjects;
}

public class BombPool : MonoBehaviour
{
    public Pool[] Pools;

    void Start()
    {
        foreach(Pool pool in Pools)
        {
            GameObject[] newObjects = new GameObject[pool.PoolSize];
            for(int i = 0; i < pool.PoolSize; i++)
            {
                GameObject newBomb = Instantiate(pool.Prefab);
                newBomb.SetActive(false);
                newObjects[i] = newBomb;
            }
            pool.GameObjects = newObjects;
        }
    }
}



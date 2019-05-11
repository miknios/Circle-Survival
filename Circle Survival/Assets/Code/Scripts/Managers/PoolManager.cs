using UnityEngine;

//na starcie tworzy obiekty na podstawie utworzonych wczesniej Pool SO
public class PoolManager : MonoBehaviour
{
    public Pool[] Pools;

    void Start()
    {
        foreach(Pool pool in Pools)
        {
            //GameObject[] newObjects = new GameObject[pool.PoolSize];
            for(int i = 0; i < pool.PoolSize; i++)
            {
                GameObject newBomb = Instantiate(pool.Prefab);
                newBomb.SetActive(false);
                //newObjects[i] = newBomb;
            }
            //pool.GameObjects = newObjects;
        }
    }
}



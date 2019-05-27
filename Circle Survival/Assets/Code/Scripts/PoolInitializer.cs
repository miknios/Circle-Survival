using UnityEngine;

//na starcie tworzy obiekty na podstawie utworzonych wczesniej Pool SO
public class PoolInitializer : MonoBehaviour
{
    public Pool[] Pools;

    void Start()
    {
        foreach(Pool pool in Pools)
        {
            for(int i = 0; i < pool.PoolSize; i++)
            {
                GameObject newBomb = Instantiate(pool.Prefab);
                newBomb.SetActive(false);
            }
        }
    }
}



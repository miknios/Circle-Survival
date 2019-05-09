using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class Pool : ScriptableObject
{
    public GameObject Prefab;
    public int PoolSize;
    public GameObject[] GameObjects;
}

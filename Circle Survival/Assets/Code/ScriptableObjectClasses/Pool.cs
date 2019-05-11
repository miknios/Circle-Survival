using UnityEngine;

//Pula obiektów
//Podajemy prefab do zinstancjonowania i wielkosc puli
[System.Serializable]
[CreateAssetMenu]
public class Pool : ScriptableObject
{
    public GameObject Prefab;
    public int PoolSize;
}

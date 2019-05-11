using UnityEngine;

//Zmienia poziom trudności zależności od podanych zmiennych
public class DifficultyFactorController : MonoBehaviour
{
    public GameParameters Parameters;
    public IntVariable Score;

    public float MinExplodeTimeFactor = 0.99f;
    public float MaxExplodeTimeFactor = 0.99f;
    public float SpawnTimeFactor = 0.97f;

    //Nowy poziom zależy od aktualnej wartości i podanego factora
    public void UpdateSpawnAndExplodeTimes()
    {
        Parameters.MinExplodeTime *= MinExplodeTimeFactor;
        Parameters.MaxExplodeTime *= MaxExplodeTimeFactor;
        Parameters.SpawnTime *= SpawnTimeFactor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyFactorController : MonoBehaviour
{
    public GameParameters Parameters;
    public IntVariable Score;

    public float MinExplodeTimeFactor = 0.99f;
    public float MaxExplodeTimeFactor = 0.99f;
    public float SpawnTimeFactor = 0.97f;

    public void UpdateSpawnAndExplodeTimes()
    {
        Parameters.MinExplodeTime *= MinExplodeTimeFactor;
        Parameters.MaxExplodeTime *= MaxExplodeTimeFactor;
        Parameters.SpawnTime *= SpawnTimeFactor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBombBehaviour : MonoBehaviour
{
    [SerializeField]
    public float explodeTime;
    [SerializeField]
    float timer;
    SpriteMask timerMask;

    void Start()
    {
        timerMask = GetComponentInChildren<SpriteMask>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        timerMask.alphaCutoff = timer / explodeTime;
        if (timer >= explodeTime)
        {
            gameObject.SetActive(false);
        }
    }
}

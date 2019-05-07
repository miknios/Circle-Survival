using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BombBehaviour : MonoBehaviour
{
    [SerializeField]
    public float explodeTime;
    [SerializeField]
    float timer;
    [SerializeField]
    UnityEvent OnTimerEnd;
    [SerializeField]
    public UnityEvent OnTouch;
    SpriteMask timerMask;
    public bool exploded;

    void Start()
    {
        timerMask = GetComponentInChildren<SpriteMask>();
    }

    private void OnEnable()
    {
        exploded = false;
    }

    void Update()
    {
        timer += Time.deltaTime;
        timerMask.alphaCutoff = timer / explodeTime;
        if (timer >= explodeTime)
        {
            OnTimerEnd.Invoke();
        }
    }

    public void Defuse()
    {
        //TODO tutaj jakas animacja wyjebania bomby
        gameObject.SetActive(false);
        //Destroy(this);
    }

    public void Explode()
    {
        //TODO tutaj jakas animacja wybuchu czy cos
        exploded = true;
        //gameObject.SetActive(false);
        //Destroy(this);
        Debug.Log("Bomb exploded!. You lost.");
    }
}

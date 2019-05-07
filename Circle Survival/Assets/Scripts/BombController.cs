using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BombController : MonoBehaviour
{
    GameManager gameManager;

    [SerializeField]
    public float explodeTime;
    [SerializeField]
    float timer;
    [SerializeField]
    public UnityEvent OnTimerEnd;
    [SerializeField]
    public UnityEvent OnTouch;
    SpriteMask timerMask;
    public bool exploded;

    void Start()
    {
        gameManager = gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        timerMask = GetComponentInChildren<SpriteMask>();
    }

    private void OnEnable()
    {
        exploded = false;
    }

    void Update()
    {
        timer += Time.deltaTime;
        SetMask(timer / explodeTime);
        if (timer >= explodeTime)
        {
            OnTimerEnd.Invoke();
        }
    }

    void SetMask(float amount)
    {
        timerMask.alphaCutoff = amount;
    }

    public void Defuse()
    {
        //TODO tutaj jakas animacja wyjebania bomby
        gameObject.SetActive(false);
        Reset();
    }

    public void Explode()
    {
        //TODO tutaj jakas animacja wybuchu czy cos
        Debug.Log("Bomb exploded!. You lost.");
        gameManager.EndGame();
    }

    void Reset()
    {
        timer = 0;
        SetMask(0);
    }
}

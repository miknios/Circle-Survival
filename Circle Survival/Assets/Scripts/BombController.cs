using UnityEngine;
using UnityEngine.Events;

public class BombController : MonoBehaviour
{
    public float ExplodeTime;
    public float Timer;
    public UnityEvent OnTimerEnd;
    public UnityEvent OnTouch;
    SpriteMask timerMask;

    public GameEvent ExplodeEvent;

    void Awake()
    {
        timerMask = GetComponentInChildren<SpriteMask>();
    }

    void Update()
    {
        Timer += Time.deltaTime;
        SetMask(Timer / ExplodeTime);
        if (Timer >= ExplodeTime)
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
        ExplodeEvent.Raise();
    }

    void Reset()
    {
        Timer = 0;
        SetMask(0);
    }
}

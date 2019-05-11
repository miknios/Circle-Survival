using UnityEngine;
using UnityEngine.Events;

public class BombController : MonoBehaviour
{
    public float ExplodeTime;
    public float Timer;
    public UnityEvent OnTimerEnd;
    public UnityEvent OnTouch;
    SpriteMask timerMask;
    bool timerActive;

    public GameEvent ExplodeEvent;

    void Awake()
    {
        timerMask = GetComponentInChildren<SpriteMask>();
    }

    void Update()
    {
        if (timerActive)
        {
            Timer += Time.deltaTime;
            SetMask(Timer / ExplodeTime);
            if (Timer >= ExplodeTime)
            {
                OnTimerEnd.Invoke();
            }
        }
    }

    void SetMask(float amount)
    {
        timerMask.alphaCutoff = amount;
    }

    public void Defuse()
    {
        StopTimer();
    }

    public void Explode()
    {
        ExplodeEvent.Raise();
    }

    public void StartTimer()
    {
        timerActive = true;
    }

    void StopTimer()
    {
        timerActive = false;
    }

    public void Reset()
    {
        Timer = 0;
        SetMask(0);
        gameObject.SetActive(false);
    }
}

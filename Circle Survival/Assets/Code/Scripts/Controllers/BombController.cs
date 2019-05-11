using UnityEngine;
using UnityEngine.Events;

//Kontrola timera bomby
//Wywolanie odpowiednich Eventow
public class BombController : MonoBehaviour
{
    bool timerActive;
    public float ExplodeTime;
    public float Timer;
    public UnityEvent OnTimerEnd;
    public UnityEvent OnTouch;

    public GameEvent ExplodeEvent;

    void Update()
    {
        if (timerActive)
        {
            Timer += Time.deltaTime;
            if (Timer >= ExplodeTime)
            {
                OnTimerEnd.Invoke();
            }
        }
    }

    public void Defuse()
    {
        StopTimer();
    }

    public void Explode()
    {
        ExplodeEvent.Raise();
    }

    public void Reset()
    {
        Timer = 0;
        gameObject.SetActive(false);
    }

    public void StartTimer()
    {
        timerActive = true;
    }

    void StopTimer()
    {
        timerActive = false;
    }
}

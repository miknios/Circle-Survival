using UnityEngine;

//Ustawia SpriteMask na podstawie aktualnej wartosci timera z BombController
public class TimerSpriteMaskSetter : MonoBehaviour
{
    BombController controller;
    SpriteMask timerMask;

    private void Awake()
    {
        timerMask = GetComponent<SpriteMask>();
        controller = GetComponentInParent<BombController>();
    }

    void Update()
    {
        SetMask(controller.Timer / controller.ExplodeTime);
    }

    void SetMask(float amount)
    {
        timerMask.alphaCutoff = amount;
    }
}

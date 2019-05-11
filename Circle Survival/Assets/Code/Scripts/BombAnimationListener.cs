using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAnimationListener : MonoBehaviour
{
    BombController bombController;

    private void Awake()
    {
        bombController = GetComponentInParent<BombController>();
    }

    public void StartTimer()
    {
        bombController.StartTimer();
    }

    public void Reset()
    {
        bombController.Reset();
    }
}

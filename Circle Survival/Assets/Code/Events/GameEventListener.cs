﻿using UnityEngine;
using UnityEngine.Events;

//Umożliwia reagowanie na wzniesienie podanego GameEventu
public class GameEventListener : MonoBehaviour
{
    public GameEvent Event;
    public UnityEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    internal void OnEventRaised()
    {
        Response.Invoke();
    }
}

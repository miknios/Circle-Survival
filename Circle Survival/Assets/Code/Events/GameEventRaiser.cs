using UnityEngine;

//Udostepnia metode do wznoszenia podanego GameEventu
public class GameEventRaiser : MonoBehaviour
{
    public GameEvent gameEvent;

    public void Raise() => gameEvent.Raise();
}
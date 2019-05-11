using UnityEngine;

//Zbiera dowolny dotyk i podnosi podany GameEvent
public class TouchAnywhereToRaise : MonoBehaviour
{
    public GameEvent GameEvent;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            foreach(Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                    GameEvent.Raise();
            }
        }
    }
}

using UnityEngine;

//Udostepnienie animatorowi odpowiednich metod BombControllera
public class BombAnimationEventListener : MonoBehaviour
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

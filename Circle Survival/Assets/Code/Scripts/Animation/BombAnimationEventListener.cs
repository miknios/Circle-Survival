using UnityEngine;

//Wywolanie odpowiednich metod BombControllera w zaleznosci od AnimationEventow
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

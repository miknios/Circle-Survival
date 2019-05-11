using UnityEngine;

//Sprawdza czy dotknięto bombę
//Jeśli dotknięto to invokuje jej UnityEvent OnTouch
public class BombHitTouchController : MonoBehaviour
{
    void Update()
    {
         CheckTouches();
    }

    void CheckTouches()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                var bomb = Physics2D.OverlapCircle(Camera.main.ScreenToWorldPoint(touch.position), 0.1f, 1 << 8);

                if (bomb != null)
                {
                    var bombBehaviour = bomb.gameObject.GetComponent<BombController>();
                    bombBehaviour.OnTouch.Invoke();
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
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
                var bomb = Physics2D.OverlapCircle(Camera.main.ScreenToWorldPoint(touch.position), 0.1f);

                if (bomb != null)
                {
                    var bombBehaviour = bomb.gameObject.GetComponent<BombBehaviour>();
                    bombBehaviour.OnTouch.Invoke();
                }
            }
        }
    }
}

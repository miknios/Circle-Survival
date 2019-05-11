using UnityEngine;

//Używany przez Score Background
//Zmienia prędkość animacji w zależności od podanego SO FloatVariable
public class RotationAnimSpeedSetter : MonoBehaviour
{
    Animator animator;
    public FloatVariable Timer;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("RotationSpeed", Mathf.Sqrt(Timer.Value / 3));
    }
}

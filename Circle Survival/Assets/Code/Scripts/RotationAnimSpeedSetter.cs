using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

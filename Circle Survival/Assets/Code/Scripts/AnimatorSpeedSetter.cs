using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSpeedSetter : MonoBehaviour
{
    public float MinSpeed = 1;
    public float MaxSpeed = 1;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        animator.speed = Random.Range(MinSpeed, MaxSpeed);
    }

}

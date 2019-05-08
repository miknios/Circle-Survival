using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    GameManager gameManager;
    public float speed;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        speed = gameManager.timer;
        if (gameManager.GameRunning)
            transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}

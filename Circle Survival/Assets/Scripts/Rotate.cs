using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if(gameManager.GameRunning)
            transform.Rotate(Vector3.forward * gameManager.scoreManager.Score * Time.deltaTime / 2);
    }
}

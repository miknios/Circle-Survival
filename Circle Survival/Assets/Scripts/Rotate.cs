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
            transform.Rotate(Vector3.forward * Time.deltaTime * (gameManager.scoreManager.Score == 0 ? 1 : gameManager.scoreManager.Score));
    }
}

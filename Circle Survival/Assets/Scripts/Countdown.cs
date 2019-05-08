using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    GameManager gameManager;
    Text countdownText;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        countdownText = GetComponent<Text>();
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        int countdown = gameManager.CountdownTime;
        for (int i = countdown; i > 0; i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSecondsRealtime(1);
        }
        countdownText.text = "GO";
        gameManager.StartGame();
        yield return new WaitForSecondsRealtime(0.5f);
        countdownText.text = "";
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    Text countdownText;

    public GameParameters GameParameters;
    public IntVariable CountdownTime;
    public GameEvent CountdownEnd;

    void Start()
    {
        countdownText = GetComponent<Text>();
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        int countdown = CountdownTime.Value;
        for (int i = countdown; i > 0; i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSecondsRealtime(1);
        }
        countdownText.text = "GO";
        CountdownEnd.Raise();
        yield return new WaitForSecondsRealtime(0.5f);
        countdownText.text = "";
    }
}

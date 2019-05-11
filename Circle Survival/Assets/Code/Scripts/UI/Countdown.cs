using System.Collections;
using UnityEngine;
using TMPro;

//Na starcie odlicza zmieniając tekst
//Na końcu wznosi CountdownEnd GameEvent
public class Countdown : MonoBehaviour
{
    TextMeshProUGUI countdownText;

    public IntVariable CountdownTime;
    public GameEvent CountdownEnd;

    void Start()
    {
        countdownText = GetComponent<TextMeshProUGUI>();
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

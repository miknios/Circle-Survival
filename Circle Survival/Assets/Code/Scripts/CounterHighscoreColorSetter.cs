using UnityEngine;
using TMPro;

public class CounterHighscoreColorSetter : MonoBehaviour
{
    public ColorVariable Color;
    public IntVariable Score;
    public IntVariable Highscore;
    TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void Set()
    {
        if(Score.Value > Highscore.Value)
            text.color = Color.color;
    }
}

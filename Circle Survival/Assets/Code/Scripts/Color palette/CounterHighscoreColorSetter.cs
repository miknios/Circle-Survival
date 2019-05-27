using UnityEngine;
using TMPro;

//Używany przez licznik punktów
//W momencie przekroczenia highscora zmienia kolor tekstu na podany
[RequireComponent(typeof(TextMeshProUGUI))]
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

using UnityEngine;
using TMPro;

public class ShowHighscoreOnEnable : MonoBehaviour
{
    TextMeshProUGUI text;
    public IntVariable Score;
    public IntVariable Highscore;

    void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        EnableOnHighscore();
    }

    public void EnableOnHighscore()
    {
        if(Score.Value == Highscore.Value)
        {
            text.text = "Highscore!";
        }
        else
        {
            text.text = "";
        }
    }
}

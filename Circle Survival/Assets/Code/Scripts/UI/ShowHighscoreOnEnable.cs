using UnityEngine;
using UnityEngine.UI;

//Włącza Image komponent jeśli zdobyto highscore
public class ShowHighscoreOnEnable : MonoBehaviour
{
    Image image;
    public IntVariable Score;
    public IntVariable Highscore;

    void Awake()
    {
        image = GetComponent<Image>();
    }

    private void OnEnable()
    {
        EnableOnHighscore();
    }

    public void EnableOnHighscore()
    {
        image.enabled = Score.Value == Highscore.Value;
    }
}

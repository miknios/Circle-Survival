using UnityEngine;
using TMPro;

//Uzywane przez licznik punktow
//Zapewnia metod kontroli tekstu wyswietlajacego punkty
public class ScoreTextSetter : MonoBehaviour
{
    public IntVariable Score;
    TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void Set()
    {
        text.text = Score.Value.ToString();
    }

    public void Clear()
    {
        text.text = "";
    }
}

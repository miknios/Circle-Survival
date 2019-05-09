using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTextSetter : MonoBehaviour
{
    public IntVariable Score;
    TextMeshProUGUI text;

    void Start()
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

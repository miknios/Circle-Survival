using UnityEngine;
using UnityEngine.UI;

public class ScoreTextSetter : MonoBehaviour
{
    public IntVariable Score;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
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

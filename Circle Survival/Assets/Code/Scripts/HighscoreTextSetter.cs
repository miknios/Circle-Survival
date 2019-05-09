using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoreTextSetter : MonoBehaviour
{
    TextMeshProUGUI text;

    public IntVariable HighScore;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        text.text = "Highscore: " + HighScore.Value;
    }
}

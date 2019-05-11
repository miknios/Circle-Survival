using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetScoreTextOnEnable : MonoBehaviour
{
    public IntVariable Score;
    TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        text.text = "Score\n" + Score.Value;
    }
}

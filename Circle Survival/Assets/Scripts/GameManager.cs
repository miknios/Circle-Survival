using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Text scoreText;

    void Update()
    {
        scoreText.text = ((int)Time.time).ToString();
    }
}

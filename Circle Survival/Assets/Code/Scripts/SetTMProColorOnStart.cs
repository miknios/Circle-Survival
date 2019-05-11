using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SetTMProColorOnStart : MonoBehaviour
{
    public ColorVariable Color;
    TextMeshProUGUI image;

    private void Awake()
    {
        image = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        image.color = Color.color;
    }
}

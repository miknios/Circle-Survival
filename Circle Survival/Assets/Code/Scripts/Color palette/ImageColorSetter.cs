﻿using UnityEngine;
using UnityEngine.UI;

//Ustawia kolor Image na podany
[RequireComponent(typeof(Image))]
public class ImageColorSetter : MonoBehaviour
{
    public ColorVariable Color;
    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {
        image.color = Color.color;
    }
}

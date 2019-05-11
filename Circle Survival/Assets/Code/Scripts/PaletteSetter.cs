using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaletteSetter : MonoBehaviour
{
    public List<ColorPalette> palettes;

    public ColorVariable FontColor;
    public ColorVariable BackgroundColor;
    public ColorVariable CircleColor;
    public ColorVariable HighscoreColor;

    private void Awake()
    {
        ColorPalette drawnPalette = palettes[Random.Range(0, palettes.Count)];

        FontColor.color = drawnPalette.FontColor;
        BackgroundColor.color = drawnPalette.BackgroundColor;
        CircleColor.color = drawnPalette.CircleColor;
        HighscoreColor.color = drawnPalette.HighscoreColor;
    }
}

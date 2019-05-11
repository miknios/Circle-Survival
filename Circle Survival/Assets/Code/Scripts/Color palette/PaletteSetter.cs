using System.Collections.Generic;
using UnityEngine;

//Losuje palete z podanych w liscie i wypelnia SO kolorow ktorych uzywaja obiekty
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

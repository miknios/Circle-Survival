using System.Collections.Generic;
using UnityEngine;

//Losuje palete z podanych w liscie i wypelnia SO kolorow ktorych uzywaja obiekty
public class PaletteSetter : MonoBehaviour
{
    public List<ColorPalette> Palettes;

    public ColorVariable FontColor;
    public ColorVariable BackgroundColor;
    public ColorVariable CircleColor;
    public ColorVariable HighscoreColor;

    private void Awake()
    {
        ColorPalette drawnPalette = Palettes[Random.Range(0, Palettes.Count)];

        FontColor.color = drawnPalette.FontColor;
        BackgroundColor.color = drawnPalette.BackgroundColor;
        CircleColor.color = drawnPalette.CircleColor;
        HighscoreColor.color = drawnPalette.HighscoreColor;
    }
}

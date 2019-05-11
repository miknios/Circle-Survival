using UnityEngine;

//Ustawia na starcie kolor tła na podany
public class CameraBackgroundColorSetter : MonoBehaviour
{
    public ColorVariable color;

    private void Start()
    {
        Camera.main.backgroundColor = color.color;
    }
}

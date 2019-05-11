using UnityEngine;

public class CameraBackgroundColorSetter : MonoBehaviour
{
    public ColorVariable color;

    private void Start()
    {
        Camera.main.backgroundColor = color.color;
    }
}

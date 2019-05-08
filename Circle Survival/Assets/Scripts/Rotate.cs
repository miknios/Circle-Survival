using UnityEngine;

public class Rotate : MonoBehaviour
{
    float speed;

    public FloatVariable Timer;

    void Update()
    {
        speed = Timer.Value;
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}

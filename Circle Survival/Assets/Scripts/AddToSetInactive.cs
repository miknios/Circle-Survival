using UnityEngine;

public class AddToSetInactive : MonoBehaviour
{
    public RuntimeSet Set;

    private void OnDisable()
    {
        Set.Add(gameObject);
    }
}

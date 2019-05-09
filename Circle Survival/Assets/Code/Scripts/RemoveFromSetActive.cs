using UnityEngine;

public class RemoveFromSetActive : MonoBehaviour
{
    public RuntimeSet set;

    private void OnEnable()
    {
        set.Remove(gameObject);
    }
}

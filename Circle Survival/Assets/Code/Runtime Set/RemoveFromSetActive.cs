using UnityEngine;

//Jeśli obiekt się stanie się aktywny to usuwa się z podanego RuntimeSeta
public class RemoveFromSetActive : MonoBehaviour
{
    public RuntimeSet set;

    private void OnEnable()
    {
        set.Remove(gameObject);
    }
}

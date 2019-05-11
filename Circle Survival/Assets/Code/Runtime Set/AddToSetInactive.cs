using UnityEngine;

//Jeśli obiekt się zwolni (stanie się nieaktywny) dodaje się do wybranego zbioru
public class AddToSetInactive : MonoBehaviour
{
    public RuntimeSet Set;

    private void OnDisable()
    {
        Set.Add(gameObject);
    }
}

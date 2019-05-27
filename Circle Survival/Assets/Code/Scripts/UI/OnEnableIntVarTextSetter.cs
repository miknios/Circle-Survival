using UnityEngine;
using TMPro;

//Używane przez highscore w głównym menu i score po przegranej
//Ustawia text na wartosc podanego IntVar
[RequireComponent(typeof(TextMeshProUGUI))]
public class OnEnableIntVarTextSetter : MonoBehaviour
{
    public IntVariable IntVar;
    TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        text.text = IntVar.Value.ToString();
    }
}

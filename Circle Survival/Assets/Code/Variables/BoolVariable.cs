using UnityEngine;

[CreateAssetMenu]
public class BoolVariable : ScriptableObject
{
    #if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
    #endif

    public bool Value;
}

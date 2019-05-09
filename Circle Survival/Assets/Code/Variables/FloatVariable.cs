using UnityEngine;

[CreateAssetMenu]
public class FloatVariable : ScriptableObject
{
    #if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
    #endif
    public float Value;
}

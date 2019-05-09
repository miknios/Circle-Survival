using UnityEngine;

[CreateAssetMenu]
public class IntVariable : ScriptableObject
{
    #if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
    #endif

    public int Value;
}

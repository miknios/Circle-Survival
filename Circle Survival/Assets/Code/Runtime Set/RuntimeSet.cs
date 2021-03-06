﻿using System.Collections.Generic;
using UnityEngine;

//Umożliwia pobranie, usunięcie i dodanie obiektu z listy i wyczyszczenie listy
[CreateAssetMenu]
public class RuntimeSet : ScriptableObject
{
    public List<GameObject> Items = new List<GameObject>();

    public GameObject Get()
    {
        return Items[0];
    }

    public void Add(GameObject gameObject)
    {
        if (!Items.Contains(gameObject))
            Items.Add(gameObject);
    }

    public void Remove(GameObject gameObject)
    {
        if (Items.Contains(gameObject))
            Items.Remove(gameObject);
    }

    public void Clear()
    {
        Items.Clear();
    }
}

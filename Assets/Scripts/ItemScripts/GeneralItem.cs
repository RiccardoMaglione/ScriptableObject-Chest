using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralItem : ScriptableObject
{
    public string Name;
    public int ID;
    public string Description;
    public TypeItem TypeGeneral;
    public Sprite Artwork;
}
public enum TypeItem
{
    Null,
    Tools,
    Ore,
    Food
}

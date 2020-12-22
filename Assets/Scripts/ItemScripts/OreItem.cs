using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChestItemOre", menuName = "ChestItem/ItemOre")]
public class OreItem : GeneralItem
{
    public int Price;
    public TypeOreItem TypeOre;

    private void Awake()
    {
        TypeGeneral = TypeItem.Ore;
    }
}
public enum TypeOreItem
{
    Null,
    Iron,
    Gold,
    Diamond
}

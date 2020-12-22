using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChestItemFood", menuName = "ChestItem/ItemFood")]
public class FoodItem : GeneralItem
{
    public int RestoreHealthValue;
    public TypeFoodItem TypeFood;

    private void Awake()
    {
        TypeGeneral = TypeItem.Food;
    }
}
public enum TypeFoodItem
{
    Null,
    Base,
    Advance
}

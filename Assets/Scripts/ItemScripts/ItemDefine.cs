using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MaglioneFramework
{
    public class ItemDefine : MonoBehaviour
    {
        public GeneralItem Item;

        public Text Name;
        public Text ID;
        public Text Description;
        public Text GeneralValue;
        public TypeItem TypeGeneral;
        public Image Artwork;
        [Header("Compile if item is an ore")]
        public Text Price;
        public TypeOreItem TypeOre;
        [Header("Compile if item is a tools")]
        public Text Durability;
        public TypeToolsItem TypeTools;
        [Header("Compile if item is a food")]
        public Text RestoreHealthValue;
        public TypeFoodItem TypeFood;

        void Start()
        {

            if (Name != null && Item.Name != null)
            {
                Name.text = Item.Name;
            }
            if (ID != null)
            {
                ID.text = Item.ID.ToString();
            }
            if (Description != null && Item.Description != null)
            {
                Description.text = Item.Description;
            }
            if (Artwork != null && Item.Artwork != null)
            {
                Artwork.sprite = Item.Artwork;
            }

            TypeGeneral = Item.TypeGeneral;

            if (Item as OreItem)
            {
                Price.text = ((OreItem)Item).Price.ToString();
                TypeOre = ((OreItem)Item).TypeOre;
            }
            else if (Item as ToolsItem)
            {
                Durability.text = ((ToolsItem)Item).Durability.ToString();
                TypeTools = ((ToolsItem)Item).TypeTools;
            }
            else if (Item as FoodItem)
            {
                RestoreHealthValue.text = ((FoodItem)Item).RestoreHealthValue.ToString();
                TypeFood = ((FoodItem)Item).TypeFood;
            }
        }
    }
}
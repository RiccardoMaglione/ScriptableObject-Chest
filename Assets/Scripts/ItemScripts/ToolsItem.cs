using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaglioneFramework
{
    [CreateAssetMenu(fileName = "NewChestItemTools", menuName = "ChestItem/ItemTools")]
    public class ToolsItem : GeneralItem
    {
        public int Durability;
        public TypeToolsItem TypeTools;

        private void Awake()
        {
            TypeGeneral = TypeItem.Tools;
        }

    }
    public enum TypeToolsItem
    {
        Null,
        Wooden,
        Stone,
        Iron,
        Gold,
        Diamond
    }
}

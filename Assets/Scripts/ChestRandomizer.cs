using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestRandomizer : MonoBehaviour
{
    public GameObject SlotChest;
    public GameObject ParentGrid;
    public GeneralItem[] ItemSO;
    
    void Start()
    {
        int Rand = Random.Range(1, 7);
        for (int i = 0; i < Rand; i++)
        {
            GameObject ChestSlots = Instantiate(SlotChest);
            ChestSlots.GetComponent<ItemDefine>().Item = ItemSO[Random.Range(0, 5)];
            ChestSlots.transform.SetParent(ParentGrid.transform);
            ChestSlots.transform.localScale = new Vector3(2,2,2);
        }
    }
}

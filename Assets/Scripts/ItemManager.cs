using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

    public string nameofItem;
    public bool addItem = true;

    public InventorySystem inventorySystem;


    public virtual void onPickup()
    {
        gameObject.SetActive(false);
    }

    public virtual void onDrop()
    {
        gameObject.SetActive(true);
    }
}

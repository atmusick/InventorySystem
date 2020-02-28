using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    //should be applied to all item types in play
    public string nameofItem;
    public bool addItem = true;

    //allows reference to item inventory
    public InventorySystem inventorySystem;


    //allows override from children if necessary
    //toggles game object off when picked up
    public virtual void onPickup()
    {
        gameObject.SetActive(false);
    }
    //toggles on when dropped
    public virtual void onDrop()
    {
        gameObject.SetActive(true); 
    }
}

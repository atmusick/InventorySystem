using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : ItemManager
{
    /*to be attached to the collectible in the scene*/
    // Start is called before the first frame update
    void Start()
    {
        addItem = true; /*sets addItem to true for InventorySystem's Pickup*/
    }
    public override void onPickup() /*overrides the virtual class onPickup from ItemManager*/
    {
        foreach (ItemManager i in inventorySystem.GetInv()) /*go through every item in the array, which is a copy of the original inventory list in inventorysystem*/
        {
            if (i.GetType() == typeof(Collectible))
            {
                inventorySystem.Drop(i);
                /*run Drop() on the item if it is of the type Collectible*/
            }

        }

        base.onPickup(); /*run onPickup from ItemManager without overriding*/
        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color;
        /*changes the player's color on pickup*/
    }
    public override void onDrop() /*run onDrop from ItemManager*/
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().color = Color.cyan;
        Destroy(gameObject);
        /*set color of player to cyan and delete the collectible*/
    }
}

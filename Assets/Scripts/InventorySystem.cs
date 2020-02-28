using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{

    public List<ItemManager> inv;
    
    // Start is called before the first frame update
    void Start()
    {
        //instantiate list
        inv = new List<ItemManager>();
    }

    //looks to itemManager to check for items in inv
    public bool HaveItemName (string nameofItem)
    {
        foreach (ItemManager item in inv)
        {
            if (nameofItem == item.nameofItem)
            {
                return true;
            }
        }
        return false;
    }

    //references self and onPickup in itemManager, adds item to inventory 
    public void Pickup (ItemManager item)
    {
        item.inventorySystem = this;
        item.onPickup();

        if(item.addItem)
        {
            if(!inv.Contains(item))
            {
                inv.Add(item);
            }
                 else
                {
                     Debug.Log ("NO");
                }
                
        }
        
    }
    //removes item from inventory
    public void Drop (ItemManager item)
    {
        if(inv.Contains(item))//if we have it
        {
            inv.Remove(item);//then remove
            item.onDrop();
        }
    }
    //stores inventory as array
    public ItemManager[] GetInv()
        {
            return inv.ToArray();
        }
    
   
}

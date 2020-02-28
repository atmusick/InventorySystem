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

    public bool HaveItemName (string itemName)
    {
        foreach (ItemManager item in inv)
        {
            if (itemName == item.itemName)
            {
                return true;
            }
        }
        return false;
    }


    public void Pickup (ItemManager item)
    {
        item.InventorySystem = this;
        item.onPickup();

        if(item.addToInventory)
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

    public void Drop (ItemManager item)
    {
        if(inv.Contains(item))
        {
            inv.Remove(item);
            item.OnDrop();
        }
    }

    public ItemManager[] GetInv()
        {
            return inv.ToArray();
        }
    
   
}

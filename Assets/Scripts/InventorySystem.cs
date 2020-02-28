using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{

    public List<Items> inv;
    
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        //instantiate list
        inv = new List<Items>();
=======

>>>>>>> Stashed changes
    }

    public bool HaveItemName (string itemName)
    {
<<<<<<< Updated upstream
        foreach (Items item in inv)
        {
            if (itemName == item.itemName)
            {
                return true;
            }
        }
        return false;
=======

>>>>>>> Stashed changes
    }


    public void Pickup (Items item)
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

    public void Drop (Items item)
    {
        if(inv.Contains(item))
        {
            inv.Remove(item);
            item.OnDrop();
        }
    }

    public Items[] GetInv()
        {
            return inv.ToArray();
        }
    
   
}

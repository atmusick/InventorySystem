using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : ItemManager
{
    // Start is called before the first frame update
    void Start()
    {
        addItem = true;
    }
    public override void onPickup()
    {
        foreach (Item I in InventorySystem.GetInv())
        {
            if (i.GetType() == typeof(boots))
            {
                InventorySystem.dropItem(i);

            }

        }

        base.onPickup();
        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color;
    }
    public override void onDrop()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().color = Color.cyan;
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Potion> InventoryObjects = new List<Potion>();
    void Start()
    {
        InventoryObjects.Add(new HealthPotion("HealthPotion", 2, 10));
        InventoryObjects.Add(new SpeedPotion("SpeedPotion", 1, 2));

    }
    private void Update()
    {
        
    }

    public virtual void UseHealthPotion(Kai player)
    {
        //potion.UsePotion();
        // buscar una apocion de sqaluid, usarla y eliminarla
        InventoryObjects[0].UsePotion(player);
    }
}

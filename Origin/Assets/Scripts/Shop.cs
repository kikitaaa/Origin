using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Inventory inventory;

    public void BuyHealthPotion()
    {
       inventory.InventoryObjects.Add(new HealthPotion("HealthPotion", 1, 10));
        Debug.Log("Poci�n de curaci�n comprada.");
    }
    public void BuySpeedPotion()
    {
       inventory.InventoryObjects.Add(new SpeedPotion("SpeedPotion", 1, 2));
        Debug.Log("Poci�n de velocidad comprada.");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Potion> InventoryObjects = new List<Potion>();
    void Start()
    {
        InventoryObjects.Add(new HealthPotion("HealthPotion", 1, 20));
        Debug.Log("Pociones de salud agregadas.");
        InventoryObjects.Add(new SpeedPotion("SpeedPotion", 1, 2));
        Debug.Log("Pociones de velocidad agregadas.");
        Debug.Log(InventoryObjects.Count);

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Kai kaiObject = GameObject.Find("Kai").GetComponent<Kai>();
            if (InventoryObjects.Exists(h => h is HealthPotion))
            {
                UseHealthPotion(kaiObject);
                Debug.Log("Pocion de salud consumida.");
            }
            else
            {
                Debug.Log("No tienes pociones de salud.");
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Kai kaiObject = GameObject.Find("Kai").GetComponent<Kai>();
            if (InventoryObjects.Exists(s => s is SpeedPotion))
            {
                UseSpeedPotion(kaiObject);
                Debug.Log("Pocion de velocidad consumida.");
            }
            else
            {
                Debug.Log("No tienes pociones de velocidad.");
            }
        }
    }

    public void UseHealthPotion(Kai player)
    {
        List<Potion> potionsToRemove = new List<Potion>();
        foreach (Potion potion in InventoryObjects)
        {
            if (potion is HealthPotion)
            {
                HealthPotion healthPotion = (HealthPotion)potion;
                //Usar la healthPotion encontrada
                healthPotion.UsePotion(player);
                Debug.Log("Healing");
                //Agregar la healthPotion encontrada a la Lista de PotionsToRemove
                potionsToRemove.Add(healthPotion);
                break;
            }
        }
        //Eliminamos todos los elementos de la Lista PotionsToRemove.
        foreach (Potion potionToRemove in potionsToRemove)
        {
            InventoryObjects.Remove(potionToRemove);
        }
    }
    public void UseSpeedPotion(Kai player)
    {
        List<Potion> potionsToRemove = new List<Potion>();
        foreach (Potion potion in InventoryObjects)
        {
            if (potion is SpeedPotion)
            {
                SpeedPotion speedPotion = (SpeedPotion)potion;
                //Usar la speedPotion encontrada
                speedPotion.UsePotion(player);
                Debug.Log("Boosting Speed");
                //Agregar la speedPotion encontrada a la Lista de PotionsToRemove
                potionsToRemove.Add(speedPotion);
                break;
            }
        }
        //Eliminamos todos los elementos de la Lista PotionsToRemove.
        foreach (Potion potionToRemove in potionsToRemove)
        {
            InventoryObjects.Remove(potionToRemove);
        }
    }
}

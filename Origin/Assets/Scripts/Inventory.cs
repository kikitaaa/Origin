using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Potion> InventoryObjects = new List<Potion>();  // Creamos una lista p�blica de objetos "Potion" llamada "InventoryObjects" y la inicializamos como una lista vac�a.
    public static Inventory instance;
     

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Kai kaiObject = GameObject.Find("Kai").GetComponent<Kai>(); // Buscamos el objeto "Kai" en la escena y obtenemos su componente "Kai"
            if (InventoryObjects.Exists(h => h is HealthPotion))  // Si existe al menos una poci�n de salud en el inventario
            {
                UseHealthPotion(kaiObject); // Usamos una poci�n de salud
                Shop.instance.RemovePotionHealth();
                Shop.instance.UpdateHealthPotionText();               
                Debug.Log("Pocion de salud consumida.");
            }
            else
            {
                Debug.Log("No tienes pociones de salud.");
            }
        }
        if (Input.GetButtonDown("Fire2")) // Si se presiona el bot�n "Fire2"
        { 
            Kai kaiObject = GameObject.Find("Kai").GetComponent<Kai>();   // Buscamos el objeto "Kai" en la escena y obtenemos su componente "Kai"
            if (InventoryObjects.Exists(s => s is SpeedPotion)) // Si existe al menos una poci�n de velocidad en el inventario
            {
                UseSpeedPotion(kaiObject); // Usamos una poci�n de velocidad
                Shop.instance.RemovePotionSpeed();
                Shop.instance.UpdateSpeedPotionText();
                Debug.Log("Pocion de velocidad consumida.");
            }
            else
            {
                Debug.Log("No tienes pociones de velocidad.");
            }
        }
    }

    public void UseHealthPotion(Kai player) // Definimos la funci�n "UseHealthPotion" que consume una poci�n de salud
    {
        List<Potion> potionsToRemove = new List<Potion>(); // Creamos una lista local de objetos "Potion" llamada "potionsToRemove" y la inicializamos como una lista vac�a
        foreach (Potion potion in InventoryObjects)   // Recorremos la lista de objetos "Potion" del inventario
        {
            if (potion is HealthPotion) // Si encontramos una poci�n de salud
            {
                HealthPotion healthPotion = (HealthPotion)potion;  // Convertimos la poci�n a un objeto "HealthPotion"
                // Usamos la poci�n de salud encontrada
                healthPotion.UsePotion(player);
                Debug.Log("Healing");
                // Agregamos la poci�n de salud encontrada a la lista "potionsToRemove"
                potionsToRemove.Add(healthPotion);
                break;
            }
        }
        
        foreach (Potion potionToRemove in potionsToRemove)  // Eliminamos todas las p�cimas en la lista "potionsToRemove" del inventario
        {
            InventoryObjects.Remove(potionToRemove);
        }
    }
    public void UseSpeedPotion(Kai player) // Definimos la funci�n "UseSpeedPotion" que consume una poci�n de velocidad
    {
        List<Potion> potionsToRemove = new List<Potion>();  // Creamos una lista local de objetos "Potion" llamada "potionsToRemove" y la inicializamos como una lista vac�a
        foreach (Potion potion in InventoryObjects)  // Recorremos la lista de objetos "Potion" del inventario
        {
            if (potion is SpeedPotion) // Si encontramos una poci�n de velocidad
            {
                SpeedPotion speedPotion = (SpeedPotion)potion;  // Convertimos la poci�n a un objeto "SpeedPotion"
                //Usar la speedPotion encontrada
                speedPotion.UsePotion(player);
                Debug.Log("Boosting Speed");
                // Agregamos la poci�n de velocidad encontrada a la lista "potionsToRemove"
                potionsToRemove.Add(speedPotion);
                break;
            }
        }       
        foreach (Potion potionToRemove in potionsToRemove) // Eliminamos todas las p�cimas en la lista "potionsToRemove" del inventario.
        {
            InventoryObjects.Remove(potionToRemove);
        }
       
    }
}

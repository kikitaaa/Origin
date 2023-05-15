using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public static Shop instance; 
    public Inventory inventory; // Invocamos al Inventario.
    public int coins = 0; // Valor inicial de la moneda
    public TMPro.TMP_Text textcoinsText; // Referencia al objeto Text en el canvas

    private void Start()
    {
        UpdateCoinsText(); // Llamamos al m�todo UpdateCoinsText.
    }
    public void BuyHealthPotion()
    {
        if (coins >= 10) // Verifica si hay suficientes monedas para comprar la poci�n
        {
            inventory.InventoryObjects.Add(new HealthPotion("HealthPotion", 1, 10)); // Sihay dinero suficiente, se agrega una poci�n al inventario.
            coins -= 10; // Resta el valor de la poci�n de las monedas
            Debug.Log("Poci�n de curaci�n comprada.");
            UpdateCoinsText();
        }
        else
        {
            Debug.Log("No tienes suficientes monedas.");
        }
    }
    public void BuySpeedPotion()
    {
        if (coins >= 2) // Verifica si hay suficientes monedas para comprar la poci�n
        {
            inventory.InventoryObjects.Add(new SpeedPotion("SpeedPotion", 1, 2));
            coins -= 2; // Resta el valor de la poci�n de las monedas
            Debug.Log("Poci�n de velocidad comprada.");
            UpdateCoinsText();
        }
        else
        {
            Debug.Log("No tienes suficientes monedas.");
        }
    }
    public void UpdateCoinsText() //Actualizamos el texto de coins y lo mostramos.
    {
        textcoinsText.text = ": " + coins.ToString();
    }

    public void AddCoins(int amount) // Agregamos coins segun la cantidad asignada.
    {
        coins += amount;
    }
}

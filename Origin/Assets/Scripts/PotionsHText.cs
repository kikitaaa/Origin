using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionsHText : MonoBehaviour
{
    public static PotionsHText instance;
    public Inventory Inventory;
    public TMPro.TMP_Text texhealthpotionsText;
    public int healthpotions = 0;

    void Start()
    {
        UpdateHealthPotionText();
    }
    public void AddHPotion()
    {
        healthpotions += 1;
        UpdateHealthPotionText();
    }

    public void UpdateHealthPotionText()
    {
        texhealthpotionsText.text = healthpotions.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Potion
{
    public int HealAmount;
    public HealthPotion(string name, int value, int HealAmount) : base(name, value)
    {
        this.HealAmount = HealAmount;
    }
    public override void Use(Kai player)
    {
        if (Input.GetButtonDown("Fire3"))
            player.Heal(20);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion 
{
    public string name;
    public int value;
 public Potion(string name, int value)
    {
        this.name = name;
        this.value = value;
    }
    public virtual void Use(Kai player)
    {
        //player.Heal(value);
        //player.SpeedMult(value);
    }
}

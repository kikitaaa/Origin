using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPotion : Potion
{
        public int SpeedMultiplier;
        public SpeedPotion(string name, int value, int SpeedMultiplier) : base(name, value)
        {
            this.SpeedMultiplier = SpeedMultiplier;
        }
    public override void Use(Kai player)
    {
        player.SpeedMult(value);
    }
}

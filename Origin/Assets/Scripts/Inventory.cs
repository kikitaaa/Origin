using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject player;
    public Potion[] potions;
    // Start is called before the first frame update
    void Start()
    {
        potions = new Potion[2];
        potions[0] = new HealthPotion("HealthPotion", 2, 10);
        potions[1] = new SpeedPotion("SpeedPotion", 3, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

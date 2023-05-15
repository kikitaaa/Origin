using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image UIImagen;
    private Kai player;
    private void Start()
    {
        UIImagen = GetComponentInChildren<Image>();
        player = FindObjectOfType<Kai>();

    }
    public void Update()
    {
        UIImagen.sprite = Resources.Load<Sprite>("Healthbar/" + player.GetComponent<Kai>().health.ToString());
    }
}

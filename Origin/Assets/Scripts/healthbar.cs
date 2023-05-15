using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image UIImagen;
    public GameObject Player;
    private void Start()
    {
        UIImagen = GetComponentInChildren<Image>();

    }
    public void Update()
    {
        UIImagen.sprite = Resources.Load<Sprite>("Healthbar/" + Player.GetComponent<Kai>().health.ToString());
    }
}

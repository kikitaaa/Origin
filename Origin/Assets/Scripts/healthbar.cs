using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Image UIImagen;
    public GameObject Player;
    public void Start()
    {
        UIImagen = GameObject.Find("healthbar").GetComponent<Image>();
    }
    public void Update()
    {
        UIImagen.sprite = Resources.Load<Sprite>("healthbar/" + Player.GetComponent<Kai>().health.ToString());
    }
}

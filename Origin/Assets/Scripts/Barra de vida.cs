using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barradevida : MonoBehaviour
{
    public Image UIImagen;
    public void Start()
    {
        UIImagen = GameObject.Find("Vida").GetComponent<Image>();
    }
    public void Update()
    {
        if(Input.GetKeyDown("q"))
            {
            UIImagen.sprite = Resources.Load<Sprite>("Barra de vidas/7");
            }
        if (Input.GetKeyDown("w"))
        {
            UIImagen.sprite = Resources.Load<Sprite>("Barra de vidas/6");
        }
    }
}

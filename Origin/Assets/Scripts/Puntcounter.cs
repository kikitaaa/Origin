using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntcounter : MonoBehaviour
{
    public TMPro.TMP_Text textpointsText;
    void Update()
    {
        textpointsText.text = ":" + GameManager.instance.GetPunt(); // invocamos la puntuación en texto.
    }
}

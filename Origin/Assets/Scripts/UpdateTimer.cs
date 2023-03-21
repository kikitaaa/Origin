using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTimer : MonoBehaviour
{
    public float time = 0;
    public TMPro.TMP_Text timeText;
    void Update()
    {
        time += Time.deltaTime; //Realizamos el contador de tiempo con el time delta time para que detecte el tiempo adecuadamente.
        timeText.text = "TIME:" + time.ToString("F2"); // invocamos el time en texto y designamos que solo use dos decimales.
    }
}

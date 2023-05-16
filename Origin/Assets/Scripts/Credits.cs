using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using static System.Net.Mime.MediaTypeNames;

public class Credits : MonoBehaviour
{
    string text0 = "Créditos " +
        "Sonidos Kai:" +
        " Ataque Melee:  Cristina Soler/ Jorge Sánchez " +
        "Mildred Idle: Cristina Soler/ Jorge Sánchez " +
        "Acido : Jorge Sánchez " +
        "Main Menú:  Cristina Soler/ Jorge Sánchez " +
        "FreeSound " +
        "Kai: Daño Salto " +
        "Luputon: Daño " +
        "Youtube: " +
        "Música de ambiente: Música Hafez " +
        "Diseño de personajes" +
        "Tienda : Sandra García Albaladejo " +
        "Diseño de fondo y complementos de escenario:" +
        "Sofia Bittar Reyes " +
        "Karen Delgado Fernández " +
        "Yolanda Gomez Segovia " +
        "Sandra García Albaladejo " +
        "Desarrollo de mecánicas c# " +
        "Sofia Bittar Reyes " +
        "Karen Delgado Fernández " +
        "Sandra García Albaladejo Diego Moreira Jacho";



    public TMP_Text text;
    float seconds = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Contexto());

    }
    IEnumerator Contexto()
    
    {
       foreach(char caracter in text0)
        {
            text.text = text.text + caracter;
            yield return new WaitForSeconds(seconds);

        }

    }

}

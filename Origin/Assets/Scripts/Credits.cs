using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using static System.Net.Mime.MediaTypeNames;

public class Credits : MonoBehaviour
{
    string text0 = "Cr�ditos " +
        "Sonidos Kai:" +
        " Ataque Melee:  Cristina Soler/ Jorge S�nchez " +
        "Mildred Idle: Cristina Soler/ Jorge S�nchez " +
        "Acido : Jorge S�nchez " +
        "Main Men�:  Cristina Soler/ Jorge S�nchez " +
        "FreeSound " +
        "Kai: Da�o Salto " +
        "Luputon: Da�o " +
        "Youtube: " +
        "M�sica de ambiente: M�sica Hafez " +
        "Dise�o de personajes" +
        "Tienda : Sandra Garc�a Albaladejo " +
        "Dise�o de fondo y complementos de escenario:" +
        "Sofia Bittar Reyes " +
        "Karen Delgado Fern�ndez " +
        "Yolanda Gomez Segovia " +
        "Sandra Garc�a Albaladejo " +
        "Desarrollo de mec�nicas c# " +
        "Sofia Bittar Reyes " +
        "Karen Delgado Fern�ndez " +
        "Sandra Garc�a Albaladejo Diego Moreira Jacho";



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

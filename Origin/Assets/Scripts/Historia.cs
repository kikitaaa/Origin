using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using static System.Net.Mime.MediaTypeNames;

public class Historia : MonoBehaviour
{
    string texto = " La historia de nuestro juego comienza con el despertar de Kai, en un sitio absolutamente desconocido, todo es totalmente nuevo ante sus ojos, incluida  su personalidad.No sabe quién es, ni de donde viene, ni que es lo que busca  exactamente.A lo largo del camino se encontrará con criaturas del bosque,  algunos les servirán de guía para su viaje y se enfrentará a otros.Derrotará a dará cuenta de que él no es el único ser involucrado en esta historia.";



    public TMP_Text textoo;
    float seconds = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Contexto());

    }
    IEnumerator Contexto()
    
    {
       foreach(char caracter in texto)
        {
            textoo.text = textoo.text + caracter;
            yield return new WaitForSeconds(seconds);

        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using static System.Net.Mime.MediaTypeNames;

public class Foreword : MonoBehaviour
{
    string text0 = " La historia de Origin comienza con el despertar de Kai en un sitio absolutamente desconocido, todo es totalmente nuevo ante sus ojos, incluida su personalidad. No sabe qui�n es, ni de donde viene, ni que es lo que busca exactamente. A lo largo del camino se encontrar� con criaturas del bosque, algunos les servir�n de gu�a para su viaje y se enfrentar� a otros.Derrotar� a dar� cuenta de que �l no es el �nico ser involucrado en esta historia.";



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

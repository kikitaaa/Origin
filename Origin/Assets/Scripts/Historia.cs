using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;

public class Historia : MonoBehaviour
{
    string texto = " dfgbyegfjkdfhahf";
    public Text textoo;
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
            yield return new WaitForSeconds(1);

        }

    }

}

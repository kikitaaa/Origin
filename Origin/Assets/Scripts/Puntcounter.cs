using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntcounter : MonoBehaviour
{
    public TMPro.TMP_Text textpointsText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textpointsText.text = ":" + GameManager.instance.GetPunt();
    }
}

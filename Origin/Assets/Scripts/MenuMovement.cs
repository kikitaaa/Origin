using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    float mousePosX;
    float mousePosY;


    void Start()
    {
        
    }

    
    void Update()
    {
        mousePosX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        mousePosY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        mousePosX = Mathf.Clamp(mousePosX, -2, 2);
        mousePosY = Mathf.Clamp(mousePosY, -2, 2);

        //this.GetComponent<RectTransform>().position = new Vector2(
        //    (mousePosX / Screen.width) * movementQuantity + (Screen.width / 2),
        //    (mousePosY / Screen.height) * movementQuantity + (Screen.height / 2));
        this.GetComponent<RectTransform>().position = Vector2.Lerp(GetComponent<RectTransform>().position, new Vector2(mousePosX, mousePosY),Time.deltaTime*0.3f) ;

        //this.GetComponent<RectTransform>().LookAt(Input.mousePosition);
        Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData //Creación de una nueva clase con nombre GameData.
{
    public Vector3 position; //Toma las coordenadas de la posición del player.
    public Vector3 cameraposition; // Toma las coordenadas de la posición de la camara.
    public GameObject coinsPos; // Toma las coordenadas de la posición de las monedas.
    public int playerhealth; //Toma los datos de la salud del player.
    public int score; //Toma los datos de la puntuación del player.
    public float time; //Toma los datos del tiempo de la partida.
    public int coins; // Toma los datos de la cantidad de coins del player.
}

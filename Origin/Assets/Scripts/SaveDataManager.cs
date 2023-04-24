using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{
    public GameObject player;
    public GameObject camPos;
    public GameObject gamemanager;
    public GameObject time;
    public GameObject coins;
    public GameObject coinsPos;
    public string savefile;
    public GameData gamedata = new GameData();

    private void Awake()
    {
        savefile = Application.dataPath + "/SaveData.json"; //Asigna la ruta del archivo de guardado en formato JSON en la carpeta de la aplicación.
        player = GameObject.FindGameObjectWithTag("Player"); //Busca el objeto del jugador en la escena y lo asigna a la variable "player".
        LoadData(); //Llama a la función "LoadData" para cargar los datos guardados previamente, si existen.
    }
    private void LoadData()
    {
        if (File.Exists(savefile)) //Verifica si el archivo de guardado existe en la ruta especificada.
        {
            string content = File.ReadAllText(savefile); //Lee el contenido del archivo de guardado.
            gamedata = JsonUtility.FromJson<GameData>(content); //Transforma el contenido del archivo en un objeto de tipo "GameData" utilizando la clase JsonUtility de Unity.
            Debug.Log("Archivo Cargado"); // Se muestra en la consola el mensaje "Archivo Cargado" indicando que hemos cargado los datos correctamente.
            // Se asignan los valores cargados a diferentes componentes del juego, como la posición del jugador, la posición de la camara, la salud del jugador, el tiempo transcurrido y la puntuación obtenida.
            player.transform.position = gamedata.position;
            camPos.transform.position = gamedata.cameraposition;
            player.GetComponent<Kai>().health = gamedata.playerhealth;
            gamemanager.GetComponent<GameManager>().points = gamedata.score;
            time.GetComponent<UpdateTimer>().time = gamedata.time;
            coins.GetComponent<Shop>().coins = gamedata.coins;
            coinsPos.transform.position = gamedata.position;


        }
        else
        {
            Debug.Log("El archivo no existe"); //Se muestra en la consola el mensaje "El archivo no existe" en caso de que el archivo a cargar no exista.
        }
    }
    private void SaveData()
    {
        GameData newdata = new GameData() //Creamos un nuevo objeto del tipo GameData con los datos actuales del juego "Posición del jugador y de la camara, salud, puntuación y tiempo.
        {
            position = player.transform.position,
            cameraposition = camPos.transform.position,
            playerhealth = player.GetComponent<Kai>().health,
            score = gamemanager.GetComponent<GameManager>().points,
            time = time.GetComponent<UpdateTimer>().time,
            coins = coins.GetComponent<Shop>().coins,
            coinsPos = coinsPos.GameObject()
        };

        string jsonstring = JsonUtility.ToJson(newdata); //Transforma el objeto de tipo GameData en formato JSON utilizando la clase JsonUtility de Unity.

        File.WriteAllText(savefile, jsonstring); //Escribe el JSON transformado en el archivo de guardado en la ruta especificada.

        Debug.Log("Archivo Guardado"); //Se muestra en la consola el mensaje "Archivo Guardado" para indicar que los datos dados han sido guardados.
    }
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{
    public GameObject player;
    public GameObject camPos;
    public GameObject gamemanager;
    public GameObject time;
    public string savefile;
    public GameData gamedata = new GameData();

    private void Awake()
    {
        savefile = Application.dataPath + "/SaveData.json";
        player = GameObject.FindGameObjectWithTag("Player");
        LoadData();
    }
    private void LoadData()
    {
        if (File.Exists(savefile))
        {
            string content = File.ReadAllText(savefile);
            gamedata = JsonUtility.FromJson<GameData>(content);
            Debug.Log("Archivo Cargado");
            player.transform.position = gamedata.position;
            camPos.transform.position = gamedata.cameraposition;
            player.GetComponent<Kai>().health = gamedata.playerhealth;
            gamemanager.GetComponent<GameManager>().points = gamedata.score;
            time.GetComponent<UpdateTimer>().time = gamedata.time;


        }
        else
        {
            Debug.Log("El archivo no existe");
        }
    }
    private void SaveData()
    {
        GameData newdata = new GameData()
        {
            position = player.transform.position,
            cameraposition = camPos.transform.position,
            playerhealth = player.GetComponent<Kai>().health,
            score = gamemanager.GetComponent<GameManager>().points,
            time = time.GetComponent<UpdateTimer>().time
        };

        string jsonstring = JsonUtility.ToJson(newdata);

        File.WriteAllText(savefile, jsonstring);

        Debug.Log("Archivo Guardado");
    }
}

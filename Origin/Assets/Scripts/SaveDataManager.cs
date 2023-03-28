using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{
    public GameObject player;
    public string savefile;
    public GameData gamedata = new GameData();

    private void Awake()
    {
        savefile = Application.dataPath + "/gamedata.json";
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
            position = player.transform.position 
        };

        string jsonstring = JsonUtility.ToJson(newdata);

        File.WriteAllText(savefile, jsonstring);

        Debug.Log("Archivo Guardado");
    }
}

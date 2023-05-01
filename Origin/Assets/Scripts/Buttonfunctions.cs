using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonfunctions : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Shop;
    public GameObject HealthPotion;
    public GameObject SpeedPotion;
  

    public void PauseTimer() //Pausamos el timer.
    {
        Time.timeScale = 0;
    }
    public void StartTimer() //Iniciamos el timer.
    {
        Time.timeScale = 1;
    }
    public void ResetPunt() //Reseteamos el timer.
    {
       GameManager.instance.ResetPunt(0);
    }
    public void PauseMenuoON() //Activa el menú de pausa.
    {
        PauseMenu.SetActive(true);
    }
    public void PauseMenuoOFF() //Desactiva el menú de pausa.
    {
        PauseMenu.SetActive(false);
    }
    public void ShopMenuoON() //Activa el menú de tienda.
    {
        Shop.SetActive(true);
        SceneManager.LoadScene("Shop");
     

    }
    public void ShopMenuoOFF() //Desactiva el menú de tienda.
    {
        Shop.SetActive(false);
        SceneManager.LoadScene("Level1");
    }
    public void ChangeScene(string name) //Cambiamos a la escena designada, en este caso iria al menu principal y limpiamos la lista de audios.
    {
        SceneManager.LoadScene(name);

        AudioManager.instance?.ClearAudioList();

        //if(AudioManager.instance != null)
        //{
        //    AudioManager.instance.ClearAudioList();
        //}
    }
    public void ExitGame() //Indicamos a la aplicación que se cierre.
    {
        Application.Quit();
    }
   

}

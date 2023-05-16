using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonfunctions : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Shop;
    public AudioClip clip;

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
    public void PauseMenuoON() //Activa el men� de pausa.
    {
        PauseMenu.SetActive(true);
    }
    public void PauseMenuoOFF() //Desactiva el men� de pausa.
    {
        PauseMenu.SetActive(false);
    }
    public void ShopMenuON() //Activa el men� de tienda.
    {
        Shop.SetActive(true);
    }
    public void ShopMenuOFF() //Desactiva el men� de tienda.
    {
        Shop.SetActive(false);
    }
    public void ChangeScene(string name) //Cambiamos a la escena designada, en este caso iria al menu principal y limpiamos la lista de audios.
    {
        SceneManager.LoadScene(name);
        AudioManager.instance.ClearAudioList();

    }
    public void ExitGame() //Indicamos a la aplicaci�n que se cierre.
    {
        Application.Quit();
    }
   
    public void StopBackgroundMusic()
    {
        AudioManager.instance.StopBackgroundMusic();
    }
    public void StartBackgroundMusic()
    {
        AudioManager.instance.PlayBackgroundMusic(clip);
    }
        
}

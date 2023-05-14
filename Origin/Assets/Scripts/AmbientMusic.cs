using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientMusic : MonoBehaviour
{
     public AudioClip ambientMusic;
    [Range(0, 1)]
    public float musicVolume;


    private void Start()
    {
        AudioManager.instance.PlayAudioOnLoop(ambientMusic, musicVolume); //Se le añade un audio en bucle a la escena del juego.
    }
}

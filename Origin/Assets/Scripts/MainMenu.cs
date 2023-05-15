using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private AudioManager audioManager;
    public AudioClip clip;
    private void Start()
    {
        audioManager = AudioManager.instance;
    }

    public void OnMainMenuActivated()
    {
        // Reproducir m�sica ambiente
        audioManager.PlayBackgroundMusic(clip, 1);
    }
}


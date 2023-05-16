using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider volumeSlider; // Referencia al objeto deslizante de volumen
    public AudioManager audioManager; // Referencia al AudioManager

    public static float currentVolume = 1f; // Variable para almacenar el volumen actual

    public void Start()
    {
        // Configurar el valor inicial del deslizador al volumen actual
        volumeSlider.value = currentVolume;
    }

    public void OnVolumeChanged()
    {
        // Llamado cuando se cambia el valor del deslizador
        float volume = volumeSlider.value;

        // Verificar si se hizo clic en el objeto deslizante
        if (volume == currentVolume)
        {
            // Si se hizo clic en el mismo valor, alternar entre 1 y 0
            volume = (volume == 1f) ? 0f : 1f;
            volumeSlider.value = volume;
        }

        // Actualizar el volumen utilizando el AudioManager
        audioManager.SetMasterVolume(volume);
        currentVolume = volume;
    }
}



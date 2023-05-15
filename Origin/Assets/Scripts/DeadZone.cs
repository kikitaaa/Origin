using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    public AudioClip playerdieSound;
    [Range(0, 2)]
    public float playerdieVolume;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //Destroy(collision.gameObject);
            SceneManager.LoadScene("SampleScene");
            GameManager.instance.time = 0;
            GameManager.instance.points = 0;
            AudioManager.instance.ClearAudioList();
            AudioManager.instance.PlayAudio(playerdieSound, playerdieVolume);


        }
        
    }
}

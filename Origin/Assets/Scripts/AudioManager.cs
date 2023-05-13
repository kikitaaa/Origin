using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static public AudioManager instance;
    public List<GameObject> activeAudioGameObjects;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        
        }
        else
        {
            instance = this;
            activeAudioGameObjects = new List<GameObject>();
            DontDestroyOnLoad(gameObject);
        }
    }
    public void SetMasterVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    //Volume: [0, 1]
    public AudioSource PlayAudio(AudioClip clip,float volume = 1)
    {
        GameObject sourceObj = new GameObject(clip.name);
        activeAudioGameObjects.Add(sourceObj);
        sourceObj.transform.SetParent(this.transform);
        AudioSource source = sourceObj.AddComponent<AudioSource>();
        source.clip = clip;
        source.volume = volume * AudioListener.volume; // Utilizamos el volumen del AudioManager multiplicado por el volumen del AudioListener
        source.Play();
        StartCoroutine(PlayAudio(source));
        return source;
    }
    public AudioSource PlayAudioOnLoop(AudioClip clip, float volume = 1)
    {
        GameObject sourceObj = new GameObject(clip.name);
        activeAudioGameObjects.Add(sourceObj);
        sourceObj.transform.SetParent(this.transform);
        AudioSource source = sourceObj.AddComponent<AudioSource>();
        source.clip = clip;
        source.volume = volume * AudioListener.volume; // Utilizamos el volumen del AudioManager multiplicado por el volumen del AudioListener
        source.loop = true;
        source.Play();
        return source;
    }
    public void ClearAudioList()
    {
        foreach (GameObject go in activeAudioGameObjects)
        {
            Destroy(go);
        }
        activeAudioGameObjects.Clear();
    }
    IEnumerator PlayAudio (AudioSource source)
    {
        while (source && source.isPlaying) {
            yield return null;
        }
        if (source)
        {
            activeAudioGameObjects.Remove(source.gameObject);
            Destroy(source.gameObject);
        }
    }
}

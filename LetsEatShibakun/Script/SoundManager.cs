using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip _sound;
    public static SoundManager instance {get; private set;}
    public AudioSource source;
    void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
        if (source == null) 
        {
            Debug.Log("The source is Null");
        }
    }

    public void PlaySound(AudioClip _sound)
    {
        if (_sound == null) 
        {
            Debug.Log("The sound is Null");
        }
        source.PlayOneShot(_sound);
    }
}

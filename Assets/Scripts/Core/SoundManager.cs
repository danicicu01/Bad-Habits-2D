using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance { get; private set; }
    private AudioSource sursa;

    private void Awake()
    {
        instance = this;
        sursa = GetComponent<AudioSource>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
       else if (instance != null && instance != this)
            Destroy(gameObject);
            
    }
    public void PlaySound(AudioClip _sound)
    {
        sursa.PlayOneShot(_sound);
    }
}

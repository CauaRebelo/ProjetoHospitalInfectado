using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    AudioSource aud;
    void Start()
    {
        aud = GetComponent<AudioSource>();
        aud.volume = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play_sound(float volume)
    {
        aud.volume = volume;
        aud.Play();
    }
}

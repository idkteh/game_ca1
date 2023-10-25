using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_player : MonoBehaviour
{
    public AudioSource[] sounds;
    
    public void play_sound(string soundName)
    {
        if (soundName == "jump")
        {
            sounds[0].Play();
        }

        else if (soundName == "key")
        {
            sounds[1].Play();
        }
    }
}

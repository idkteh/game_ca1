using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_player : MonoBehaviour
{
    public AudioSource[] sounds;
    
    public void play_sound(string soundName)            // takes care of the sound, i'd say self-explanatory, there's a reference to it in player
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

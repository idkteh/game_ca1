using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    
    public SpriteRenderer sprite;
    //public audio_player play_audio;

    public void collect()
    {               
        sprite.enabled = false;                  // hides sprite
    }

    public void reset_key()
    {
        
        sprite.enabled = true;                  // turns sprite back on
    }
 

    
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    [HideInInspector]public bool is_collected;
    public SpriteRenderer sprite;
    
    public void collect()
    {
        is_collected = true;
        sprite.enabled = false;

    }

    public void reset_key()
    {
        is_collected=false;
        sprite.enabled = true;  
    }
    void Start()
    {
        is_collected = false;
    }

    
    
}
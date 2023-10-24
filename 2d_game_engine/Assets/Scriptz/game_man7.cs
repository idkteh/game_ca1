using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_man7 : MonoBehaviour
{
    public key the_key;
    [HideInInspector]public bool key;
    [HideInInspector] public int coin;
    public wall wall;
    
    public void reset_game()
    {
        key = false;
        coin = 0;
        the_key.reset_key();
        wall.reset_wall();
    }
    
    public void win()
    {
        Debug.Log("we did it joe"); //CHANGE IT
    }
    public void getKey()
    {
        key = true;
        the_key.collect();             //when we get key, key gets hidden
        wall.destroy_wall();           // wal gets destroyed
    }
    void Start()
    {
        reset_game();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

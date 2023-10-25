using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_man7 : MonoBehaviour               //   game manager for general stuff
{
    public key the_key;                              // reference to the object key, used for sprites
    //[HideInInspector]public bool key;                     
    public wall wall;
    public UI_man8 ui_man;
   


    public void reset_game()           
    {
        //key = false;
        the_key.reset_key();                 //resets key,  
        wall.reset_wall();
        ui_man.reset_ui();
    }
    
    public void win()
    {
        Debug.Log("we did it joe"); //CHANGE IT
        ui_man.WIN();
    }
    public void getKey()
    {
        //key = true;
        the_key.collect();             //when we get key, key gets hidden
        wall.destroy_wall();           // wal gets destroyed
        ui_man.getKey();
    }
    void Start()
    {
        reset_game();
    }

  
}

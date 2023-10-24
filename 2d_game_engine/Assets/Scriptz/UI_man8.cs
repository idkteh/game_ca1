using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_man8 : MonoBehaviour
{
    public Image keycon; //key icon 
   
    public void reset_ui()
    {
        keycon.enabled = true;
    }

    private void Start()
    {
        reset_ui();
    }

    public void getKey()
    {
        keycon.enabled = false;  
    }
    
}

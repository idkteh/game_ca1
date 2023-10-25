using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_man8 : MonoBehaviour
{
    public Image keycon;          // key icon 
    public Image panel;           // panel
    public TMP_Text you_win;      // you win text
    public void reset_ui()
    {
        keycon.enabled = true;
        you_win.enabled = false;
        panel.enabled = false;
    }

    private void Start()
    {
        reset_ui();
    }

    public void getKey()
    {
        keycon.enabled = false;  
    }

    public void WIN()
    {
        you_win.enabled = true;
        panel.enabled = true;      

    }
    
   
}

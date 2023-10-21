using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class wall : MonoBehaviour
{
    public TilemapCollider2D tile_col;
    public TilemapRenderer sprite;
    
    public void destroy_wall()
    {
        tile_col.enabled = false; //disables collider
        sprite.enabled = false; //disabled sprites
     
    }

    public void reset_wall()
    {
        tile_col.enabled = true;
        sprite.enabled = true;
    }
}

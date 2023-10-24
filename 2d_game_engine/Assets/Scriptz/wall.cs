using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class wall : MonoBehaviour
{
    public TilemapCollider2D tile_col;      // assignes collider to variable
    public TilemapRenderer sprite;          // assignes sprite to variable
    
    public void destroy_wall()
    {
        tile_col.enabled = false; // disables collider
        sprite.enabled = false; // hides sprite
     
    }

    public void reset_wall()
    {
        tile_col.enabled = true;     // turns on collider
        sprite.enabled = true;       // turns sprite back on
    }
}

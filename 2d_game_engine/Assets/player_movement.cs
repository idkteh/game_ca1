using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 1.5f;
    public float jump_height = 2f;

    public Rigidbody2D body; //creating
                             //
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // collects input from left/right arrow or a/d
        body.velocity = new Vector2 (horizontalInput*speed,body.velocity.y ); // setting the velocity, whatever the input is * speed, not changing the y axis
   
   }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x,jump_height); // setting the the velocity, keeps the x axis and changes y axis to whatever jump_height is

    }
}

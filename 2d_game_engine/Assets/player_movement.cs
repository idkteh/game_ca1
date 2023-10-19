using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class player_movement : MonoBehaviour
{
    public float speed = 1.5f;
    public float jump_height = 2f;
    public LayerMask ground_layer;
    public Transform check_for_ground;
    public float check_for_ground_rad = 0.2f;
    private bool grounded;

    public Rigidbody2D body; //creating
                             
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
       grounded = Physics2D.OverlapCircle(check_for_ground.position, check_for_ground_rad,ground_layer); //checks if character is on ground, uses overlap circle on character
       
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // collects input from left/right arrow or a/d
        body.velocity = new Vector2 (horizontalInput*speed,body.velocity.y ); // setting the velocity, whatever the input is * speed, not changing the y axis
        if (Input.GetKey(KeyCode.Space)&&grounded) //checks if we use space
        {
            Jump();
        }
   }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x,jump_height); // setting the the velocity, keeps the x axis and changes y axis to whatever jump_height is

    }

    public void reset_player()
    {
        body.velocityX = 0;   //stops player movement
        body.velocityY = 0;   
        transform.position = new Vector3 (-1.264f,-0.517f, 0); //teleports player to starting position
    }
 
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "spike") //if the colider colides with the collision box named spike my poor raddish dies 
        {
            reset_player();
        }

    }
}

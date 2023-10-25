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
    public float check_for_ground_rad = 0.2f;             // variables
    private bool grounded;
    private bool double_jump;
    public game_man7 game_manager;
    public audio_player play_audio;
    private bool can_move = true;

    public Rigidbody2D body; //creating
    public SpriteRenderer sprite; //reference to the render
                             
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(can_move) {
            grounded = Physics2D.OverlapCircle(check_for_ground.position, check_for_ground_rad, ground_layer); //checks if character is on ground, uses overlap circle on character

            float horizontalInput = Input.GetAxisRaw("Horizontal"); // collects input from left/right arrow or a/d

            //Debug.Log(horizontalInput);
            if (horizontalInput < 0) //if it's facing left, flip sprite, else don't flips
            {
                sprite.flipX = true;
            }
            else if (horizontalInput > 0)
            {

                sprite.flipX = false;
            }

            if (grounded)
            {
                double_jump = true; //everytime you on ground, double_jump resets
            }

            body.velocity = new Vector2(horizontalInput * speed, body.velocity.y); // setting the velocity, whatever the input is * speed, not changing the y axis
        }
        
        if (transform.position.y < -4.75)
        {
            reset_player();   //if player falls from the level it resets position 
        }

    }

    private void Update() //runs differently than fixedupdate
    {
        if (can_move)
        {
            if (Input.GetKeyDown(KeyCode.Space) && grounded) //checks if we use space and is grounded
            {
                Jump();

            }
            else if (Input.GetKeyDown(KeyCode.Space) && double_jump) //checks if you've used space and you have double jump left
            {
                double_jump = false; //can't do more double jumps
                Jump();

            }
        }
       
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x,jump_height);    // setting the velocity - speed, keeps the x axis and changes y axis to whatever jump_height is
        play_audio.play_sound("jump");
        //Debug.Log("Jump," + double_jump);
    }


    public void reset_player()
    {
        body.velocityX = 0;   //stops player movement
        body.velocityY = 0;   
        transform.position = new Vector3 (-1.264f,-0.517f, 0); //teleports player to starting position
        game_manager.reset_game();
    }
 
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "spike") //if the colider colides with the collision box named spike my poor raddish dies 
        {
            reset_player();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision) //checks collsions with object that trigger on
    {
       if(collision.gameObject.tag == "key")
        {
            game_manager.getKey(); //if we touch key then we run key method
            play_audio.play_sound("key");
            Destroy(collision.gameObject);

        }
        else if(collision.gameObject.tag == "kiddo")
        {
            game_manager.win();      //if we reach the kid we win
            body.velocityY = 0;
            body.velocityX = 0;
            can_move = false;
        }
    }
}

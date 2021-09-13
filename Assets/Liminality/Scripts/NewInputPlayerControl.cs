using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using System;
public class NewInputPlayerControl : MonoBehaviour
{
    private InputActions inputActions;
    private InputAction movement, aiming;

    //Adjustable settings
    public float moveSpeed = 50f, maxSpeed = 5f, fallMultiplier = 2.5f, meleeReach = 1f, jumpForce = 7f, shotLength = 5.0f;
    public bool airborne;
    public Animator animator; //TODO: Implement an animator

    private Rigidbody2D rb;
    //private SpriteRenderer spriteRenderer;

    //Movement variables
    //private Vector2 move, moveVelocity, jumpVelocity; //Not usded in current iteration
    public static Vector3 direction;

    //Player Stats
    public float hpAmountPlayer, hpAmountEnemy;
    bool enemyIsDead = false; //TODO: Move to enemy script

    private void Awake()
    {
        //Creates the control scheme
        inputActions = new InputActions();
    }

    private void OnEnable()
    {
        //Triggered by events
        inputActions.Enable();

        /*
            I will be completely honest, I am still not 100% sure how these work or could be modified
            outside of the tutorial that I watched. My understanding of the code below is that the
            game is listening for actions (Player/Aim, Player/Jump, Player/Movement, etc) and when it
            sees that the buttons were pressed to trigger the actions, it executes the function/method
            in this script (the "+= Jump" part).

            If you want to see where I got this, I followed this tutorial:
            https://www.youtube.com/watch?v=YHC-6I_LSos
        */

        //These create the events that trigger the player actions
        movement = inputActions.Player.Movement;
        movement.Enable();

        inputActions.Player.Movement.performed += Move;
        inputActions.Player.Movement.Enable();

        aiming = inputActions.Player.Aim;
        aiming.Enable();

        inputActions.Player.Aim.performed += Aim;
        inputActions.Player.Aim.Enable();

        inputActions.Player.Jump.performed += Jump;
        inputActions.Player.Jump.Enable();

        inputActions.Player.Melee.performed += Melee;
        inputActions.Player.Melee.Enable();
    }

    //I don't think this is actually working. Still need to do some more research. See comment block above
    private void OnDisable()
    {
        movement.Disable();
        inputActions.Player.Jump.Disable();
    }

    private void Aim(InputAction.CallbackContext context)
    {
        float magnitude = ((aiming.ReadValue<Vector2>().y)*(aiming.ReadValue<Vector2>().y) + (aiming.ReadValue<Vector2>().x)*(aiming.ReadValue<Vector2>().x));
        // Sets the pivot point of the ray to be at the front of the player character
        Vector3 pivotPoint = Vector3.Scale(new Vector3(0.4f, 0.1f, 0), direction);

        //This is the actual collision line. The hit variable is storing the object that the raycast collides with
        RaycastHit2D hit = Physics2D.Raycast(transform.position + pivotPoint, transform.TransformDirection(aiming.ReadValue<Vector2>().x, aiming.ReadValue<Vector2>().y, 0), shotLength * magnitude);
        //Arguements for RaycastHit2D Physics2D.Raycast(Vector2 origin, Vector2 direction, float distance)

        //Checks if the raycast hits anything
        if(hit)
        {
            Hit(hit);
        }
    }

    void Hit(RaycastHit2D hit)
    {
        Debug.Log("Hit Something : " + hit.collider.name);
        if(hit.collider.gameObject.tag != "Player" && hit.collider.gameObject.tag != "Ground") //Only changes the color if the contextect hit is an enemy. TODO: will need to be modified to something more robust but for now I have it set up this way for debugging purposes
            hit.transform.GetComponent<SpriteRenderer>().color = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); //Changes the objects color for debugging purposes
    }

    private void Jump(InputAction.CallbackContext context)
    {
        if(airborne == false) //TODO: I don't like how this works. Need to rework this to actually disable infinite jumping
        {
            //Jumping in action. TODO: Change so jump height is dependent on how long the jump button is pressed and held down
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            animator.SetBool("isJumping", true); //TODO: Implement an animator
            airborne = true; //turning this off enables multi jumping
        }
    }

    private void Melee(InputAction.CallbackContext context)
    {
        animator.SetTrigger("Attack");
        // animator.SetBool("isAttacking", true);


        // Sets the pivot point of the ray to be at the front of the player character
        Vector3 pivotPoint = Vector3.Scale(new Vector3(0.4f, 0.1f, 0), direction);
        Debug.DrawRay(transform.position + pivotPoint, Vector2.right, Color.red, 0.1f);

        //This is the actual collision line. The hit variable is storing the object that the raycast collides with
        RaycastHit2D hit = Physics2D.Raycast(transform.position + pivotPoint, Vector2.right, meleeReach);
        //Arguements for RaycastHit2D Physics2D.Raycast(Vector2 origin, Vector2 direction, float distance)

        //Checks if the raycast hits anything
        if(hit)
        {
            Hit(hit);
        }
        // animator.SetBool("isAttacking", false);
    }

    private void Move(InputAction.CallbackContext context)
    {
        //Sprite turns around depending on direction
        if (movement.ReadValue<Vector2>().x < 0) //Changed this from (rb.velocity.x >= 0) to what it is now so that players can change their sprite direction even if they're not moving in that direction.
        {
            //Old method. This flipped the entire contextect and anything attached to the contextect as well. This was a bit jarring when the camera was attached
            //transform.localScale = new Vector3(-1, 1, 1);
            //direction = new Vector3(-1, 1, 1);

            GetComponent<SpriteRenderer>().flipX = true;
            direction = -transform.localScale;
        }
        if (movement.ReadValue<Vector2>().x > 0)
        {
            //transform.localScale = new Vector3(1, 1, 1); //Old method
            GetComponent<SpriteRenderer>().flipX = false;
            direction = transform.localScale;
        }
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
    }

    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hpAmountPlayer = 5; //Currently not used TODO: Update enemy to attack and make player take damage
        hpAmountEnemy = 5;
    }

    private void FixedUpdate()
    {
        //Update movement
        Vector2 horizontalDirection = movement.ReadValue<Vector2>();
        rb.AddForce(Vector2.right * horizontalDirection * moveSpeed);

        //Speed Limits //TODO: Implement when there is more terrain to work with
        if (rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        }
        if (rb.velocity.x < -maxSpeed)
        {
            rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
        }

        //Altered gravity. The player character will spend more time reaching the apex of the jump, and the gradually fall faster to the ground
        if(rb.velocity.y < 0)
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
    }

    //Update is called once per frame
    void Update()
    {
    //Aiming. TODO: Polish this mechanic some more
        //Magnitude is required to adjust the length of the aiming line
        float magnitude = ((aiming.ReadValue<Vector2>().y)*(aiming.ReadValue<Vector2>().y) + (aiming.ReadValue<Vector2>().x)*(aiming.ReadValue<Vector2>().x));
        // Sets the pivot point of the ray to be at the front of the player character
        Vector3 pivotPoint = Vector3.Scale(new Vector3(0.4f, 0.1f, 0), direction);

        //Draws a line with the right analong stick based on the direction and magnitude. The further the stick us tilted, the further the line will draw
        //Only visible in the Scene view //TODO: Draw aiming line in game view.
        Debug.DrawRay(transform.position + pivotPoint, transform.TransformDirection(aiming.ReadValue<Vector2>().x, aiming.ReadValue<Vector2>().y, 0) * shotLength * magnitude, Color.red, 0.1f);


    //Melee Attack
        // if (Input.GetButtonDown("Fire1")) //TODO: Implement an attack
        // {
        //     //animator.SetTrigger("attack"); //TODO: Implement an animator
        //     Debug.Log("Fire1 was pressed");
        // }

    //Player Death
        if (hpAmountPlayer <= 0) //TODO: Implement enemy attacks to hurt the player
        {
            Debug.Log("Player was killed");
            Destroy(gameObject, 1f);
        }

    //Enemy Death
    if (hpAmountEnemy <= 0 && enemyIsDead == false)
        {
            enemyIsDead = true;
            Debug.Log("Enemy was killed");
            //animator.SetBool("enemyDeath", true); //TODO: Implement an animator
            Destroy(GameObject.Find("Enemy"), 1f); //Destroys the contextect after 1 second
        }

    //Update animator
    //animator.SetFloat("currentSpeed", Mathf.Abs(Input.GetAxisRaw("Horizontal"))); //TODO: Implement an animator
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    //Check for landing
        if (collision.gameObject.CompareTag("Ground"))
        {
            airborne = false;
            rb.velocity = Vector2.zero;
            animator.SetBool("isJumping", false); //TODO: Implement an animator
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            if(hpAmountEnemy > 0)
            {
                hpAmountEnemy -= 1;
                Debug.Log("Enemy took 1 damage. They have " + hpAmountEnemy + " HP");
            }
            else
            {
                Debug.Log("Stop! Stop! He's already dead!");
            }
        }
    }
}

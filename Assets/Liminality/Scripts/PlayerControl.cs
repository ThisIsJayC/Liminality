using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerControl : MonoBehaviour
{
    // Adjustable settings
    public float moveSpeed = 50f, maxSpeed = 5, jumpHeight = 150f;
    public bool airborne;
    public Animator animator;

    private Rigidbody2D rb;

    // Movement variables
    private Vector2 moveVelocity, jumpVelocity;
    public float hpAmountPlayer, hpAmountEnemy;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hpAmountPlayer = 5;
        hpAmountEnemy = 5;

    }

    // Update is called once per frame
    void Update()
    {

    // Sprite turns around depending on direction
        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

    // Might as well jump
        if (Input.GetButtonDown("Jump") && airborne == false)
        {
            Vector2 jumpVelocity = new Vector2(0, jumpHeight);
            rb.AddForce(jumpVelocity);
            animator.SetBool("isJumping", true);
            airborne = true;
        }

    //Melee Attack
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("attack");

        }

    //Player Death
        if (hpAmountPlayer <= 0)
        {
            Destroy(gameObject);
        }
    //Enemy Death
    if (hpAmountEnemy <= 0)
        {
            animator.SetBool("enemyDeath", true);
            Destroy(GameObject.Find("Enemy"), 1f);
        }

    //Update animator
    animator.SetFloat("currentSpeed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
    //Check for landing
        if (collision.gameObject.CompareTag("Ground"))
        {
            airborne = false;
            rb.velocity = Vector2.zero;
            animator.SetBool("isJumping", false);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hpAmountEnemy -= 1;
        }

    }
    private void FixedUpdate()
    {

    // Get the LR button direction and apply it to the sprite
        Vector2 horizonalDirection = new Vector2(Input.GetAxis("Horizontal"),0);
        moveVelocity = Vector2.right * moveSpeed * horizonalDirection ;

        rb.AddForce(moveVelocity);

    //Speed Limits
        if (rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        }
        if (rb.velocity.x < -maxSpeed)
        {
            rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
        }
    }
}

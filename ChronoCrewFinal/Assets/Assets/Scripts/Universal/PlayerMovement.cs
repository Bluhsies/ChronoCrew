using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float jumpHeight;

    [SerializeField] private int exJumpsValue;
    [SerializeField] private Transform groundCheck; // Checks transformation is on ground (in this case, player).
    [SerializeField] private float checkRadius; // Set radius of circular collision detector at start-up.
    [SerializeField] private LayerMask whatIsGround; // Use layers to determine ground.

    private Rigidbody2D rb;

    private int exJumps;
    private int jumpInv = 0; // Due to animator issues, this will stop the animator forcing idle and jump at the same time.

    float horizontalMove = 0f; // Sprite rendering for changing direction.
    private bool isGrounded; // Being on the ground is true or false.
    private bool facingRight = true;

    private Vector2 playerVelocity;
    private Vector3 currentScale;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Script Started");
        exJumps = exJumpsValue;

        rb = GetComponent<Rigidbody2D>();
        currentScale = transform.localScale;
    }

    void FixedUpdate()
    {
        // Only needs to be *reasonably* right to keep track of this.
        isGrounded = Physics2D.IsTouchingLayers(gameObject.GetComponent<Collider2D>(), whatIsGround);
        // Generates a small circular collider detector to find out whether this unit is touching the ground.
        // Circle overlapping detection @ GroundCheck game object pos; given radius, and 'ground' is determined by Ground layer.
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpInv > 0) jumpInv--;
        //animator.SetBool("isJumping", true);
        if (isGrounded == true && jumpInv == 0)
        {
            animator.SetBool("isJumping", false);
            exJumps = exJumpsValue;
        }
        //Debug.Log("Player movement: " + playerVelocity);

        if (Input.GetButtonDown("Jump"))
        {
            //Debug.Log("Jump 2 Detected");
            CharacterJump();
            animator.SetBool("isJumping", true);
            jumpInv = 5;
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            //Debug.Log("Horizontal2 Entered");
            horizontalMove = playerSpeed * Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
            animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

            if (Input.GetAxis("Horizontal") > 0 && !facingRight) FlipHorizontal();
            else if (Input.GetAxis("Horizontal") < 0 && facingRight) FlipHorizontal();
            // Better way to do y velocity; means you can move left AND jump, rather than the old sticky 'stop to jump then move'.
        }
    }
    void CharacterJump()
    {
        if (exJumps > 0)
        {
            exJumps--;
            Debug.Log("Jump Count:" + exJumps);
            rb.velocity = new Vector2(playerVelocity.x, jumpHeight);
        }
    }

    private void FlipHorizontal()
    {
        facingRight = !facingRight;
        currentScale.x *= -1;
        transform.localScale = currentScale;
    }
}
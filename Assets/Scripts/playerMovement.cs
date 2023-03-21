using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    //PlayerControl controls;
    private PlayerControl controls;
    float direction = 0;

    public float speed = 400;
    bool isFacingRight = true;

    public Rigidbody2D playerRB;
    public Animator animator;


    //initialising controls

    private void Awake()
    {
        controls = new PlayerControl();
        controls.Enable();
        //checking for 1d axis with the action mat
        controls.room.move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };

    }


    // Update is called once per frame
    // update is to control the speed of the player and edit their x and y position
    void Update()
    {
        playerRB.velocity = new Vector2(direction * speed * Time.deltaTime, playerRB.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(direction));
        //checks which direction the character is moving and flips animation
        if (isFacingRight && direction < 0 || !isFacingRight && direction >0)
            Flip();
    }

    //using the x axis to flip the character animation when the left arrow key is pressed
    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }
}

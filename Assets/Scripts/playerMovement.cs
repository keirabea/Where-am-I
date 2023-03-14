using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    PlayerControl controls;
    float direction = 0;

    public float speed = 10000;

    public Rigidbody2D playerRB;

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
        
    }
}

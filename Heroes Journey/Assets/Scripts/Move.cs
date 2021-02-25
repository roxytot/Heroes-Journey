using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5;  // setting speed that the character moves at (public so that appears in the inspector)

    float xInput, yInput;    // 2D position of the object

    Rigidbody2D rb;   // variable of class Rigidbody

    SpriteRenderer sp;  // variable of class SpriteRenderer

    private void Awake(){  // run once, and instantiates objects
            rb = GetComponent<Rigidbody2D>();      // Rigidbody is attached to the player using the rb variable
            sp = GetComponent<SpriteRenderer>();    // Gives us access to spriterenderer
    }

    private void FixedUpdate()  // updates with every frame
    {
         xInput = Input.GetAxis("Horizontal");          // getting input from horizontal axis (L or R arrow key or A and D)
         //yInput = Input.GetAxis("Vertical");            //getting input from vertical axis (up or down arrow key or w and s)

        //  transform.Translate(xInput * moveSpeed, yInput * moveSpeed, 0);   // applying the user defined speed to the input in x and y (i.e. left arrow move and applying 5 movespeed to that)
         transform.Translate(xInput * moveSpeed, 0, 0);   // applying the user defined speed to the input in x and y (i.e. left arrow move and applying 5 movespeed to that)
        // transform.position += new Vector3(xInput, 0, 0) * Time.deltaTime * moveSpeed;

         PlatformMover();
         FlipPlayer();   
    }
    
    void PlatformMover() { // velocity along y axis stays constant
        rb.velocity = new Vector2(moveSpeed * xInput, rb.velocity.y);  // this is modifying the velocity and direction along x axis.
    }
    
    void FlipPlayer(){

        if(rb.velocity.x<-0.01f){      //moving to the left
            sp.flipX=true;              // flip the character image (mirror)
        }else if(rb.velocity.x>0.01f){    //moving to the right
            sp.flipX=false;             // character does not flip
        }
    }    
}

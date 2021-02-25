using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [Header("Jump setup")]
    public float jumpStrength = 5f;
    public KeyCode key = KeyCode.Space;

    [Header("Ground setup")]
    public string groundTag = "Ground";
    public bool checkGround = true;  // assume that object is sitting on the ground
    private bool canJump = true;
    Rigidbody2D rb;    // assume that object can jump
    private void Awake()
    {  // run once, and instantiates objects
        rb = GetComponent<Rigidbody2D>();      // Rigidbody is attached to the player using the rb variable
    }

    // Update is called once per frame
    void Update()
    {
        if (canJump && Input.GetKeyDown(key))   // if jumping is allowed and space is pressed
        {
            // rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);   // apply a force to the object of size jumpStrength in vertical direction
            rb.AddForce(new Vector2( 0, jumpStrength), ForceMode2D.Impulse);   // apply a force to the object of size jumpStrength in vertical direction
            canJump = !checkGround;  // if ground is not touched, object cannot jump again
        }
    }

    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (checkGround && collisionData.gameObject.CompareTag(groundTag))    // if on the ground and the tag of the object involved in the collision is "ground"
        {
            canJump = true;    // allow jumping
        }
    }
}

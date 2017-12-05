using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Variables
    [Header("Movement Values")]
    public float movementSpeed = 10f, jumpHeight = 10f;
    [HideInInspector]
    public Rigidbody2D rigi;
    [HideInInspector]
    public Vector2 moveDirection;
    [HideInInspector]
    public Transform groundCheckOrigin;
    [Header("GroundCheck Variables")]
    public LayerMask ground;
    public bool grounded;

    void Start()
    {
        if(rigi == null)
        rigi = gameObject.GetComponentInParent<Rigidbody2D>();
        if(groundCheckOrigin == null)
        groundCheckOrigin = transform.Find("GroundCheckOrigin");
    }

    public void PlayerMovement(float h,float v)
    {
        #region PlayerController: Movement, Jumping, GroundCheck
        #region GroundCheck
        // Check to see if the player is touching the ground
        if (Physics2D.Raycast(groundCheckOrigin.position, Vector2.down, 0.5f, ground))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        #endregion
        #region Movement / Jumping
        // If the player is grounded, allow for full movement
        if (grounded)
        {
            moveDirection = new Vector2(h, v);
            rigi.velocity = new Vector2(moveDirection.x * movementSpeed, rigi.velocity.y);
        }

        // Jumping

        #endregion
        #endregion
    }

    // DEBUGGING
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(groundCheckOrigin.position, Vector2.down);
    }

}

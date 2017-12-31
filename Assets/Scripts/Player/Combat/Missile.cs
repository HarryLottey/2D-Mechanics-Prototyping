using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Handles properties for all missile spells


    public Rigidbody2D rigi;
    public Collider2D col;
    public SpriteRenderer rend;
    public float force = 15f;

    [Header("AIR Spell Variables")]
    float visibleVelocity = 5.5f;
    float destroyVelocity = 2.5f;


    // Use this for initialization
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        rend = GetComponent<SpriteRenderer>();
        // Forward direction at the force defined.
        rigi.AddRelativeForce(Vector2.right * force, ForceMode2D.Impulse);
    }

    private void Update()
    {
        // Destroy air missile based on current velocity
        if(gameObject.tag == "AIR" && rigi.velocity.magnitude < visibleVelocity)
        {
            // SET collider trigger to false
            col.isTrigger = false;
            // Remove Sprite
            rend.sprite = null;
            // Instantiate dissipate animation

            if(rigi.velocity.magnitude < destroyVelocity)
            {
                // Delet this
                Destroy(gameObject);
            }    
        }



    }
}


///
/// Notes about the bahaviours of different spell types.
/// 
// AIR:
/// Air spells that are missile oriented have a fast accelleration but slow down fast and once they fall under a certain speed threshold they will breakdown into harmless gusts of wind
/// the smaller the projectile size the quicker it will be for it to break down. Unique mechanic for air missilles: Hold down fire button to charge up a larger missile.
/// 
// WATER:
/// Water spells that are missile oriented have...
/// 
// EARTH:
/// Earth spells that are missile oriented have...
/// 
// FIRE:
/// Fire spells that are missile oriented have...

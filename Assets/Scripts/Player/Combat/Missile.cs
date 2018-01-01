using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Handles properties for all missile spells

       /// <URGENT>
       /// TODO: Make an instance of spell stats attatched to the prefab of the spell.
       /// it will be used for communication between scripts and modifying properties in certain ways per object.
       /// </URGENT>

    public SpellBook accessSpells;

    public Rigidbody2D rigi;
    public Collider2D col;
    public SpriteRenderer rend;
    public float force = 15f;

    public LayerMask spell;
    public LayerMask player;
    public LayerMask wall;

    public float damage;

    [Header("AIR Spell Variables")]
    float visibleVelocity = 5.5f;
    float destroyVelocity = 2.5f;



    // Use this for initialization
    void Start()
    {
        #region Connecting References
        accessSpells = GameObject.FindGameObjectWithTag("Player").GetComponent<SpellBook>();
        rigi = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        rend = GetComponent<SpriteRenderer>();
        #endregion
        // Forward direction at the force defined.
        rigi.AddRelativeForce(Vector2.right * force, ForceMode2D.Impulse);


    }

    private void Update()
    {
        #region AIR MISSILE SPELLS
        // IF we are refering to AIR Missile in particular
        if (accessSpells.assignedSpells[0].ID == 0)
        {
            // Damage scales with the speed the projectile is traveling.
            // Base damage * the current speed;
            // public float for debug to see damage on each prefab.
            damage = accessSpells.assignedSpells[0].Damage = 3.5f * rigi.velocity.magnitude;
        }

        if(gameObject.tag == "AIR")
        {
            // Reduce size of sprite based on current speed.
        }

        // Destroy air missile based on current velocity || ALL AIR SPELLS beacuse of tag and not ID reference
        if(gameObject.tag == "AIR" && rigi.velocity.magnitude < visibleVelocity)
        {
            // SET collider trigger to true
            col.isTrigger = true;
            // Remove Sprite
            rend.sprite = null;
            // Instantiate dissipate animation
            // OR setactive false object to play animation
            if(rigi.velocity.magnitude < destroyVelocity)
            {
                // Delet this
                Destroy(gameObject);
            }    
        }
        // Check around the collider radius with a small offset (collidersize is dynamic) to check if we are colliding with a wall
        if (gameObject.tag == "AIR" && Physics2D.OverlapCircle(transform.position, (col as CircleCollider2D).radius + 0.2f, wall))
        {
            rigi.AddRelativeForce(-Vector2.right * force * 2); // Reduce the velocity when colliding with a wall
        }
        #endregion

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

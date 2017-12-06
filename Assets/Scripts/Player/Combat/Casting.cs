using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script defines the action of casting, which will be called through the usercontroller
public class Casting : MonoBehaviour
{
    public SpellBook accessSpells;

    [Header("Casting System Values")]
    public float simultaneousCastTimer = 0.2f, simReset = 0.2f; // When the timer reaches zero after an ability is used the player becomes unable to simeltaneous cast.
    public float comboCastTimer = 1.0f, comReset = 1.0f; // When the timer reaches zero after an ability is used, the player becomes unable to continue a combo of spells.
    public bool comboCast, slot1Cast, slot2Cast, simultaneousCast; // Bools will go active which will allow us to activate specific casting patterns.

    [Header("Spell Isntantiation Variables")]
    public Vector3 spellCastOrigin;
    public Vector3 cursorDirection;

    #region Spell GameObjects (Animated Sprite)
    public GameObject airStrikeProjectile; // Game object with animated sprite to be instantiated
    public GameObject waterStrikeProjectile;
    public GameObject earthStrikeProjectile;
    public GameObject fireStrikeProjectile;

    #endregion

    private void Awake()
    {
        accessSpells = gameObject.GetComponentInParent<SpellBook>();
        airStrikeProjectile = Resources.Load("Sprites/AirStrike") as GameObject;
    }

    // This is just a cast which is not special in any way.
    public void RegularCast(int spellID)
    {
        // Instantiate GameObject projectile
        // at the player position in the direction of the cursor.

        Instantiate(accessSpells.assignedSpells[spellID].Sprite, spellCastOrigin, Quaternion.identity);
        

        
    }
}

  


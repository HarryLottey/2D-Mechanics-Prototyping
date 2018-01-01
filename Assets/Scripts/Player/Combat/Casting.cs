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
    public float chargeLimit = 2.5f; // Time of charging needed before it becomes a charged spell
    public float chargeTimer = 0f; // Timer that counts up to the limit.
    float chargeMultiplier; // This will increase once charging has started, and modify spell numbers based on how high this stat gets.
    public GameObject spellCastOrigin;
    GameObject spellCast;

    

    private void Awake()
    {
        accessSpells = gameObject.GetComponentInParent<SpellBook>();
    }

    // This is just a cast which is not special in any way.
    public void RegularCast(int spellID)
    {
        // Instantiate the prefab correlating with the spellID, set the direction to that of the cursor from the spellcast origin.
        spellCast = Instantiate(accessSpells.assignedSpells[spellID].Prefab, spellCastOrigin.transform.position, Quaternion.Euler(new Vector3(0,0,spellCastOrigin.transform.eulerAngles.z)));     
    }

    public void ShiftModifierCast(int spellID)
    {

    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            chargeTimer += 0.5f;
        }

        if (Input.GetMouseButton(0))
        {
            chargeTimer += 0.01f;
        }

        if (Input.GetMouseButtonUp(0))
        {
            chargeTimer = 0f;
        }
    }

}

  


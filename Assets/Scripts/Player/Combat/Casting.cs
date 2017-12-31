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

}

  


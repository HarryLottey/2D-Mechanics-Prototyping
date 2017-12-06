using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : MonoBehaviour
{
    // This script calls fucntions by user input from other scripts which have defined those functions.
    SpellBook accessSpells;
    Movement move;
    Casting cast;

    void Awake()
    {
        accessSpells = gameObject.GetComponentInParent<SpellBook>();

        if (move == null)
            move = gameObject.transform.Find("[ScriptsReference]").GetComponent<Movement>();

        if (cast == null)
            cast = gameObject.transform.Find("[ScriptsReference]").GetComponent<Casting>();

    }

    void Start()
    {
        
    }
    
    // Apply functions that always check for input
    void Update()
    {
        #region Apply Movement via Axis Movement
        float LeftRightMovement = Input.GetAxis("Horizontal"); // User input // Keys: A, D. Are assigned for horizontal or left and right movement
        float VerticalMovement = 0; // Blank for now       
        move.PlayerMovement(LeftRightMovement, VerticalMovement);
        #endregion

        #region Cast Spells via MouseButton Input

        // STORE THE INDEX OF ASSIGNED SPELLS, so we can cast them

        if (Input.GetMouseButton(0))
        {
            // TEMPORARY MAKE IT DYNAMIC
            cast.RegularCast(0);
        }

        #endregion

    }

    /*

    IEnumerator CastSpell()
    {
        SpellBook spellToCast = gameObject.GetComponent<SpellBook>();
        Event e;

        simultaneousCastTimer -= Time.deltaTime;
        // If the timer is greater than 0 then we are eligible to combine spells
        if (simultaneousCastTimer > 0)
        {
            simultaneousCast = true;
            // If timer is below 0 and simCast still true, set it to false.
            if(simultaneousCastTimer < 0 && simultaneousCast == true)
            {
                simultaneousCast = false;
            }
        }
        // If both inputs are triggered during the small window of time to simcast then activate simcast
        if (simultaneousCast && Input.GetMouseButtonDown(0) && Input.GetMouseButtonDown(1))
        {
            // call simcast
        }

        // Regular Cast

        if (slot1Cast)
        {
           // Cast(spellToCast.assignedSpells[0]); // Left click
        }

        if (slot2Cast)
        {
           // Cast(spellToCast.assignedSpells[1]); // Right Click
        }

        float cd1 = spellToCast.assignedSpells[0].CoolDown;
        float cd2 = spellToCast.assignedSpells[1].CoolDown;

        yield return new WaitForSeconds(0);

    }
    */


}

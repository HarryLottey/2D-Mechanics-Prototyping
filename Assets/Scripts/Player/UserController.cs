using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : MonoBehaviour
{
    // This script calls fucntions by user input from other scripts which have defined those functions.
    SpellBook accessSpells;
    Movement move;
    Casting cast;

    #region Input Variables for spellcasting
    

    #endregion

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

        // Cooldown timer for spell actions




        if (Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.LeftShift))
        {
            StartCoroutine(SpellSlot1Casting());
        }

        if(Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.LeftShift))
        {
            // Shift Modifier cast here
        }

        if (Input.GetMouseButtonDown(1))
        {
            // 1 = the second spell in the list of assigned spells
            cast.RegularCast(accessSpells.assignedSpells[1].ID);
        }


        #endregion

    }

    IEnumerator SpellSlot1Casting()
    {
        yield return new WaitForSeconds(0.005f);
        // If the mousebutton is lifted, a charge spell was not intended and a regular spell will be fired.
        if (cast.chargeTimer < cast.chargeLimit)
        {
            if(cast.chargeTimer > 0.05)
            {
                StopCoroutine(SpellSlot1Casting());
            }
            // 0 = the first spell in the list of assigned spells
            // ID is passed so that we call an int to activate a spell by ID number
            cast.RegularCast(accessSpells.assignedSpells[0].ID);
        }
        // reset timer once spellcasting is complete.       
        float cd = accessSpells.assignedSpells[0].CoolDown;
        yield return new WaitForSeconds(cd);
    }

}

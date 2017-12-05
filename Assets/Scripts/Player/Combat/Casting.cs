﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script defines the action of casting, which will be called through the usercontroller
public class Casting : MonoBehaviour
{
    [Header("Casting System Values")]
    public float simultaneousCastTimer = 0.2f, simReset = 0.2f; // When the timer reaches zero after an ability is used the player becomes unable to simeltaneous cast.
    public float comboCastTimer = 1.0f, comReset = 1.0f; // When the timer reaches zero after an ability is used, the player becomes unable to continue a combo of spells.
    public bool comboCast, slot1Cast, slot2Cast, simultaneousCast; // Bools will go active which will allow us to activate specific casting patterns.

    SpellBook accessSpells;

    private void Awake()
    {
        accessSpells = gameObject.GetComponentInParent<SpellBook>();
    }

    // This is just a cast which is not special in any way.
    public static IEnumerator RegularCast()
    {

        

        yield return new WaitForSeconds(0);
    }
}

  

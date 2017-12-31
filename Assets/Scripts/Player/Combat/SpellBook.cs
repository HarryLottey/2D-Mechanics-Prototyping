using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(UserController))]
public class SpellBook : MonoBehaviour
{
    // This script acts like an inventory for our spells, it stores unlocked spells, and assigns spells for the player to cast.

    public List<Spells> acquiredSpells = new List<Spells>(); // Spells you have unlocked
    public List<Spells> assignedSpells = new List<Spells>(); // Spells you have assigned (2 Max)
    
  

    void Start()
    {
        StartCoroutine(unlockSpellsTier1());
        assignedSpells.Add(new Spells()); // Empty Spell slots
        assignedSpells.Add(new Spells());

        for (int i = 0; i < assignedSpells.Count; i++)
        {
            // Assigning aquired spells to be used. Defaults to first two.
            assignedSpells[i] = acquiredSpells[i];
        }
    }

    void AddSpell(int id) // Add a spell by ID to the list of acquired spells
    {
        for (int i = 0; i < acquiredSpells.Count; i++)
        {
            if(acquiredSpells[i].SpellName == null)
            {
                acquiredSpells[i] = SpellGen.CreateSpell(id);
                Debug.Log("added Item: " + acquiredSpells[i].SpellName);
                return;
            }
        }
    }

    IEnumerator unlockSpellsTier1()
    {
        acquiredSpells.Capacity = 3;
        assignedSpells.Capacity = 1;
        acquiredSpells.Add(new Spells());
        acquiredSpells.Add(new Spells());
        acquiredSpells.Add(new Spells());
        acquiredSpells.Add(new Spells());

        for (int i = 0; i < acquiredSpells.Count; i++)
        {
            AddSpell(i); // Assign spells over the top of the empty spots we made 
        }

        yield return new WaitForSeconds(0);
    }

    // maybe this needs to be handled via UI // Assign spell based on what the user has chosen
    IEnumerator assignSpells()
    {
        yield return new WaitForSeconds(0);
    }

    private void OnGUI() // DEBUG
    {
        if (GUI.Button(new Rect(60, 60, 120, 120), "debug"))
        {
            Debug.Log(acquiredSpells[0].SpellName);
        }
    }
}



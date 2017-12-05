using UnityEngine;

public static class SpellGen
{
    public static Spells CreateSpell(int spellID)
    {
        Spells temp = new Spells();
        #region Variables // DefaultStateBlank
        string spellname = "";
        string description = "";
        string icon = "";
        string sprite = "";
        string animation = ""; // Redundant
        int damage = 0;
        float cooldown = 0;
        float radius = 0;
        int castrange = 0;
        spellEffect statusEffect = spellEffect.AIR; // default
        spellType type = spellType.MISSILE; // default
        

        //spelltype
        //spelleffect

        #region SpellData
        switch (spellID)
        {
            // Tier 1 Spells 
            case 0:
                castrange = 50;
                damage = 15;
                cooldown = 1f;
                radius = 0;
                spellname = "air strike";
                description = "a low level air missile";
                icon = "airstrikeI";
                sprite = "airstrikeS";
                type = spellType.MISSILE;
                statusEffect = spellEffect.AIR;
                break;
            case 1:
                castrange = 50;
                damage = 15;
                cooldown = 1f;
                radius = 0;
                spellname = "water strike";
                description = "";
                icon = "waterstrikeI";
                sprite = "waterstrikeS";
                type = spellType.MISSILE;
                statusEffect = spellEffect.WATER;
                break;
            case 2:
                castrange = 50;
                damage = 15;
                cooldown = 1f;
                radius = 0;
                spellname = "earth strike";
                description = "";
                icon = "earthstrikeI";
                sprite = "earthstrikeS";
                type = spellType.MISSILE;
                statusEffect = spellEffect.EARTH;
                break;
            case 3:
                castrange = 50;
                damage = 15;
                cooldown = 1f;
                radius = 0;
                spellname = "fire strike";
                description = "";
                icon = "firestrikeI";
                sprite = "firestrikeS";
                type = spellType.MISSILE;
                statusEffect = spellEffect.FIRE;
                break;

                // Tier 2 spells
        }

        #endregion

        #region Temp Connect
        temp.ID = spellID;
        temp.SpellName = spellname;
        temp.Description = description;
        temp.CastRange = castrange;
        temp.Damage = damage;
        temp.CoolDown = cooldown;
        temp.Radius = radius;
        temp.SpellType = type;
        temp.SpellEffect = statusEffect;
        temp.Icon = Resources.Load("Icons/" + icon) as Sprite;
        temp.Sprite = Resources.Load("Sprites/" + sprite) as Sprite;
        // type
        // effect
        #endregion
        return temp;
        #endregion

    }



}

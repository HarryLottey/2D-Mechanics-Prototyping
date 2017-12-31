using UnityEngine;

public static class SpellGen
{

    // This script sets data to create spells

    public static Spells CreateSpell(int spellID)
    {
        #region variables
        Spells temp = new Spells();
        string spellname = "";
        string description = "";
        string icon = "";
        string prefab = "";
        int damage = 0;
        float cooldown = 0;
        float radius = 0;
        int castrange = 0;
        Spells.spellEffect statusEffect = Spells.spellEffect.AIR; // default
        Spells.spellType type = Spells.spellType.MISSILE; // default
        #endregion

        #region SpellData
        switch (spellID)
        {
            // Tier 1 Spells /// PLAYER SPELLS
            case 0:
                castrange = 50;
                damage = 15;
                cooldown = 1f;
                radius = 0;
                spellname = "air strike";
                description = "a low level air missile";
                icon = "airstrikeI";
                prefab = "airstrikeS";
                type = Spells.spellType.MISSILE;
                statusEffect = Spells.spellEffect.AIR;
                break;
            case 1:
                castrange = 50;
                damage = 15;
                cooldown = 1f;
                radius = 0;
                spellname = "water strike";
                description = "";
                icon = "waterstrikeI";
                prefab = "waterstrikeS";
                type = Spells.spellType.MISSILE;
                statusEffect = Spells.spellEffect.WATER;
                break;
            case 2:
                castrange = 50;
                damage = 15;
                cooldown = 1f;
                radius = 0;
                spellname = "earth strike";
                description = "";
                icon = "earthstrikeI";
                prefab = "earthstrikeS";
                type = Spells.spellType.MISSILE;
                statusEffect = Spells.spellEffect.EARTH;
                break;
            case 3:
                castrange = 50;
                damage = 15;
                cooldown = 1f;
                radius = 0;
                spellname = "fire strike";
                description = "";
                icon = "firestrikeI";
                prefab = "firestrikeS";
                type = Spells.spellType.MISSILE;
                statusEffect = Spells.spellEffect.FIRE;
                break;        
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
        temp.Prefab = Resources.Load("Spells/" + prefab) as GameObject;
        temp.SpellType = type;
        temp.SpellEffect = statusEffect;
        return temp;
        #endregion
    }
}

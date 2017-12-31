using UnityEngine;
using System.Collections;

[System.Serializable]
public class Spells
{
    #region ENUMS
    public enum spellType { MISSILE, AOECAST, SELFCAST }
    // Missile: the spell projects forwards like a projectile or lazer
    // AOECAST: the spell is cast in area of effect around the cursor position
    // SELFCAST: the spell is cast and apply effects dirrectly to the player
    public enum spellEffect { AIR, WATER, EARTH, FIRE }

    #endregion
    #region Variables & parameters
    #region privateVariables

    private int id, castRange;
    private float damage, coolDown, radius;
    private string spellName, description;
    private Sprite icon, animation;
    private GameObject prefab;
    private spellType _spelltype;
    private spellEffect _spelleffect;

    #endregion
    #region Constructors
    public void SpellConstructor(int itemId, string spellName, Sprite spellIcon, spellType spelltype,
        spellEffect spelleffect, GameObject prefab, Sprite animation)
    {
        
        id = itemId;
        this.spellName = spellName;
        icon = spellIcon;
        this.prefab = prefab;
        this.animation = animation;
        _spelltype = spelltype;
        _spelleffect = spelleffect;

        // Essential parameters each new spell needs
    }
    #endregion
    #region public variables
    // GET & SET private variables to public ones, so variables can be referenced
    public int ID
    {  
        get { return id; }
        set { id = value; }
    }
    public int CastRange
    {
        get { return castRange; }
        set { castRange = value; }
    }
    public float Damage
    {
        get { return damage; }
        set { damage = value; }
    }
    public float CoolDown
    {
        get { return coolDown; }
        set { coolDown = value; }
    }
    public float Radius
    {
        get { return radius; }
        set { radius = value; }
    }
    public string SpellName
    {
        get { return spellName; } 
        set { spellName = value; }
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public Sprite Icon
    {
        get { return icon; }
        set { icon = value; }
    }
    public GameObject Prefab
    {
        get { return prefab; }
        set { prefab = value; }
    }
    public Sprite Animation
    {
        get { return animation; }
        set { animation = value; }
    }
    public spellType SpellType
    {
        get { return _spelltype; }
        set { _spelltype = value; }
    }
    public spellEffect SpellEffect
    {
        get { return _spelleffect; }
        set { _spelleffect = value; }
    }


    

    #endregion
    #endregion    
}





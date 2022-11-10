using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// create asset menu creates a menu option for unity
[
    CreateAssetMenu(
        fileName = "Encounter",
        menuName = "Encounter/Create new Encounter")
]
public class EncounterBase : ScriptableObject
{
    [SerializeField]
    string encounterName;

    [TextArea]
    [SerializeField]
    string description;

    // battle sprites
    [SerializeField]
    Sprite frontSprite;

    [SerializeField]
    Sprite backSprite;

    // type
    [SerializeField]
    EncounterType type1;

    [SerializeField]
    EncounterType type2;

    // base stats
    [SerializeField]
    int maxHp;

    [SerializeField]
    int attack;

    [SerializeField]
    int defense;

    [SerializeField]
    int spAttack;

    [SerializeField]
    int spDefense;

    [SerializeField]
    int speed;

    [SerializeField]
    List<LearnableSpells> learnableSpells;

    public string EncounterName
    {
        get
        {
            return encounterName;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public Sprite FrontSprite
    {
        get
        {
            return frontSprite;
        }
    }

    public Sprite BackSprite
    {
        get
        {
            return backSprite;
        }
    }

    public EncounterType Type1
    {
        get
        {
            return type1;
        }
    }

    public EncounterType Type2
    {
        get
        {
            return type2;
        }
    }

    public int MaxHp
    {
        get
        {
            return maxHp;
        }
    }

    public int Attack
    {
        get
        {
            return attack;
        }
    }

    public int Defense
    {
        get
        {
            return defense;
        }
    }

    public int SpAttack
    {
        get
        {
            return spAttack;
        }
    }

    public int SpDefense
    {
        get
        {
            return spDefense;
        }
    }

    public int Speed
    {
        get
        {
            return speed;
        }
    }

    public List<LearnableSpells> LearnableSpells
    {
        get
        {
            return learnableSpells;
        }
    }
}

[System.Serializable]
public class LearnableSpells
{
    [SerializeField]
    SpellBase spellBase;

    [SerializeField]
    int level;

    public SpellBase Base
    {
        get
        {
            return spellBase;
        }
    }

    public int Level
    {
        get
        {
            return level;
        }
    }
}

public enum EncounterType
{
    None,
    Normal,
    Fire,
    Water,
    Electric,
    Grass,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon
}

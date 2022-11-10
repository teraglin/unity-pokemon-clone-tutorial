using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spell", menuName = "Encounter/Create new spell")]
public class SpellBase : ScriptableObject
{
    [SerializeField]
    string spellName;

    [TextArea]
    [SerializeField]
    string description;

    [SerializeField]
    EncounterType type;

    [SerializeField]
    int power;

    [SerializeField]
    int accuracy;

    [SerializeField]
    int pp;

    public string SpellName
    {
        get
        {
            return spellName;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public EncounterType Type
    {
        get
        {
            return type;
        }
    }

    public int Power
    {
        get
        {
            return power;
        }
    }

    public int Accuracy
    {
        get
        {
            return accuracy;
        }
    }

    public int PP
    {
        get
        {
            return pp;
        }
    }
}

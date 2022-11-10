using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter
{
    EncounterBase _base;

    int level;

    public int HP { get; set; }

    public List<Spell> Spells { get; set; }

    public Encounter(EncounterBase ebase, int elevel)
    {
        _base = ebase;
        level = elevel;
        HP = _base.MaxHp;

        Spells = new List<Spell>();
        foreach (var spell in _base.LearnableSpells)
        {
            if (spell.Level <= level) Spells.Add(new Spell(spell.Base));

            if (Spells.Count >= 4) break;
        }
    }

    public string Name
    {
        get
        {
            return _base.EncounterName;
        }
    }

    public int Attack
    {
        get
        {
            return Mathf.FloorToInt((_base.Attack * level) / 100f) + 5;
        }
    }

    public int Defense
    {
        get
        {
            return Mathf.FloorToInt((_base.Defense * level) / 100f) + 5;
        }
    }

    public int SpAttack
    {
        get
        {
            return Mathf.FloorToInt((_base.SpAttack * level) / 100f) + 5;
        }
    }

    public int SpDefense
    {
        get
        {
            return Mathf.FloorToInt((_base.SpDefense * level) / 100f) + 5;
        }
    }

    public int Speed
    {
        get
        {
            return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5;
        }
    }

    public int MaxHp
    {
        get
        {
            return Mathf.FloorToInt((_base.MaxHp * level) / 100f) + 10;
        }
    }
}

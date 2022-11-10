using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell
{
 public SpellBase Base { get; set; }   

 public int PP {get; set;}

 public Spell(SpellBase sBase)
 {
    Base = sBase;
    PP = sBase.PP;
 }
}

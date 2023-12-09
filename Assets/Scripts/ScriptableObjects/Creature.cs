using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CreatureScriptableObject", menuName = "ScriptableObjects/Creature")]
public class Creature : ScriptableObject
{

    public string creature_name;
    public Sprite icon;
    public Animator animator;
    
    public Ability[] abilities;

    public int base_health;
    public float accuracy;
    public int[] strength_effects;
    public Effect[] weakness_effects;

}

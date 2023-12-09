using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AbilityScriptableObject", menuName = "ScriptableObjects/Ability")]
public class Ability : ScriptableObject
{

    public string ability_name;
    public Sprite ability_icon;

    public float lvl_adder;
    public float lvl_multiplier;

    public enum player_type
    {
        none,
        all,
        all_friendly,
        all_enemies,
        target_any,
        target_friendly,
        target_enemies
    }

    [Header("Damaging")]
    public player_type damaged_targets;
    public int damaged_target_count;
    public int damage;

    [Header("Healing")]
    public player_type healed_targets;
    public int healed_target_count;
    public int healing;

    [Header("Effects")]
    public player_type under_effect_targets;
    public int under_effect_target_count;
    public Effect effect;
}

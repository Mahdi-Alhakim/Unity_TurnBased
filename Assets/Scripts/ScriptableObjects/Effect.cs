using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectScriptableObject", menuName = "ScriptableObjects/Effect")]
public class Effect : ScriptableObject
{

    public string effect_name;
    public Sprite icon;

    public Shader effect_shader;



}

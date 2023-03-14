using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterSprite", menuName = "Dialogue/CharacterSprite", order = 1)]
public class CharacterSpriteSO : ScriptableObject
{
    public string CharacterName;
    public Sprite CharacterSprite;
}

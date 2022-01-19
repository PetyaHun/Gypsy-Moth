using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Character")]
public class characterData : ScriptableObject
{
    public string characterName = "Default";
    public Texture2D myTexture;
    public string Description = "Default";
}

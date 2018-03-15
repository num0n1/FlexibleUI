using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "DefaultUIData", menuName = "FlexibleUIData")]
public class FlexibleUIData : ScriptableObject
{
    public Sprite sprite;
    public Color color = Color.white;
    public SpriteState buttonSpriteState;
    public Image.Type imageType;


}

using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Create New Card", fileName = "New Card Info")]
public class Stats : ScriptableObject
{
    public Sprite image;
    public string name;
    [TextArea] public string description;
    public short rageValue;
    public short attackValue;
}
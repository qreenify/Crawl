using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Create New Card", fileName = "New Card Info")]
public class CardInfo : ScriptableObject
{
    public Sprite image;
    public short rageCost;
    public short rageGain;
    public short damage;
    public short damageTaken;
    public short rageRequirement; 
    [TextArea] public string description;
}
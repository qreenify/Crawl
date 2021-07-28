using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Cards/New Card Collection", fileName = "New Card Collection")]
public class CardCollection : ScriptableObject
{
   public List<CardInfo> cards;
}

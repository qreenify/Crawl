using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Item/New Item", fileName = "New Item")]
public class PlayerItems : ScriptableObject
{
   public GameObject item1;
   public Text name;
   public Text description;
   public Stats stats;
}
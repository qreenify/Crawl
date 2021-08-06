using System.Threading;
using TMPro;
using UnityEngine;

namespace Gameplay
{
    public class EnemyDamageText
    {
        public TextMeshProUGUI text;
        
        public void EnemyDamage()
        {
            text.enabled = true;
            Thread.Sleep(2000);
            text.enabled = false;
        }
    }
}
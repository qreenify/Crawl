using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class PlayerStats : MonoBehaviour
        {
            public short maxHealth = 100;
            public short currentHealth;
            public short maxRage = 100;
            public short currentRage;

            public HealthBar healthBar;
            public RageBar rageBar;
            public Image rageImage;

            private void Start()
            {
                currentHealth = maxHealth;
                healthBar.SetMaxHealth(maxHealth);
                currentRage = 0;
                rageBar.SetMaxRage(maxRage);
            }

            private void Update()
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    GetRage(10);
                }
            }

            private void GetRage(short rage)
            {
                if (currentRage == 100)
                {
                    rageBar.SetRage(currentRage += -110);
                    Debug.Log(currentRage + " currentRage over 100");
                }
                currentRage += rage;
                rageBar.SetRage(currentRage);
            }

            public void TakeDamage(short damage)
            {
                currentHealth -= damage;
                healthBar.SetHealth(currentHealth);
            }
        }
}
    
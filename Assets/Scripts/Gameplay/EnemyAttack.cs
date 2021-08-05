using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class EnemyAttack : MonoBehaviour
    {
        public short damage1 = 10;
        public short damage2 = -15;
        public short damage3 = -20;
        public short damage4 = -25;
        public GameObject enemy;
        public Turn Turn;
        public HealthBar healthBar;
        public TextMeshPro enemyDamage;
        public TextMesh hey;
        public short currentHealth;


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Attack1();
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Attack2();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Attack3();
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                Attack4();
            }
        }

        
        
        public void Attack1()
        {
            currentHealth = (short) (currentHealth + damage1);
            healthBar.SetHealth(currentHealth);
            enemyDamage.text = currentHealth.ToString();
        }
        public void Attack2()
        {
            currentHealth += damage2;
            healthBar.SetHealth(currentHealth);
            enemyDamage.text = currentHealth.ToString();
        }
        public void Attack3()
        { 
            currentHealth += damage3;
            healthBar.SetHealth(currentHealth);
            enemyDamage.text = currentHealth.ToString();
        }
        public void Attack4()
        {
            currentHealth += damage4;
            healthBar.SetHealth(currentHealth);
            enemyDamage.text = currentHealth.ToString();
        }
        
    }
}
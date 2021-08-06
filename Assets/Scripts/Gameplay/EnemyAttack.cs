using System;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gameplay
{
    public class EnemyAttack : MonoBehaviour
    {
        public short damage1 = -10;
        public short damage2 = -15;
        public short damage3 = -20;
        public short damage4 = -25;
        public GameObject enemy;
        public Turn Turn;
        public HealthBar healthBar;
        public TextMeshProUGUI enemyDamageText;
        public short currentHealth;


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Attack1();
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                Attack2();
            }
            if (Input.GetKeyDown(KeyCode.H))
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
            enemyDamageText.text = damage1.ToString();
            EnemyAttackAnimation();
        }

        

        public void Attack2()
        {
            currentHealth += damage2;
            healthBar.SetHealth(currentHealth);
            enemyDamageText.text = damage2.ToString();
            EnemyAttackAnimation();
        }
        public void Attack3()
        { 
            currentHealth += damage3;
            healthBar.SetHealth(currentHealth);
            enemyDamageText.text = damage3.ToString();
            EnemyAttackAnimation();
        }
        public void Attack4()
        {
            EnemyDamageOn();
            currentHealth += damage4;
            healthBar.SetHealth(currentHealth);
            enemyDamageText.text = damage4.ToString();
            EnemyAttackAnimation();
            EnemyDamageOff();
        }
        
        public void EnemyDamageOn()
        {
            enemyDamageText.enabled = true;
        }

        public void EnemyDamageOff()
        {
            enemyDamageText.enabled = false;
        }

        private void EnemyAttackAnimation()
        { 
            
            //TODO: Enemy Attack Animation
            Debug.Log("Enemy Attack Animation");
        }
    }
}
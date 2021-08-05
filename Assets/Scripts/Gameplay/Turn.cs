using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Gameplay
{
    public class Turn : MonoBehaviour
    {
        public short maxTurn;
        public short currentTurn;
        public string turnCounter;
        public Text turnText;

        private void Start()
        { 
            turnCounter = currentTurn.ToString();
            turnCounter = turnText.text;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                NextTurn();
                ShowTurn();
            }
        }

        void NextTurn()
        {
            if (currentTurn == 10)
            {
                SceneManager.LoadScene("LooseScene");
                return;
            }
            currentTurn++;
            turnCounter = currentTurn.ToString();
            turnCounter = turnText.text;
        }

        void ShowTurn()
        {
            string one;
            string two;
            string three;
            one = currentTurn.ToString("0");
            two = "/";
            three = maxTurn.ToString("0");
            turnText.text = one + two + three;
        }
    }
}
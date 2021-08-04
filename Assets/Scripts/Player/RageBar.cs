using System;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class RageBar : MonoBehaviour
    {
        public Slider slider;

        public void SetMaxRage(short rage)
        {
            slider.maxValue = rage;
        }

        public void SetRage(short rage)
        {
            slider.value = rage;
        }
    }
}
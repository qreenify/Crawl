using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class HealthBar : MonoBehaviour
    {
        public Slider slider;

        public void SetMaxHealth(short health)
        {
            slider.maxValue = health;
            slider.value = health;
        }

        public void SetHealth(short health)
        {
            slider.value = health;
        }
    }
}
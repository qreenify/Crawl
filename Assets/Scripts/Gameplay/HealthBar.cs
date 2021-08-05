using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Gameplay
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
            if (slider.value == 0)
            {
                SceneManager.LoadScene("LooseScene");
            }
        }
    }
}
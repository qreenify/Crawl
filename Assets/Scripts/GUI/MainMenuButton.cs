using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    public void OnEnable()
    {
        Time.timeScale = 0;
    }

    public void OnDisable()
    {
        Time.timeScale = 1;
    }
}

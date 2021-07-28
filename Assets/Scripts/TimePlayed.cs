using System;
using UnityEngine;
using UnityEngine.UI;

public class TimePlayed : MonoBehaviour
{
    public Text timerText;
    public DateTime newTime;
    private DateTime startTime;

    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void FixedUpdate()
    {
        newTime = DateTime.Now;
        TimeSpan timePlayed;
        timePlayed = newTime - startTime;
        timerText.text = timePlayed.ToString("g");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    private string mainScene = "MainScene";
    public Button playButton;
    
    public void Play()
    {
        SceneManager.LoadScene(mainScene);
    }
}

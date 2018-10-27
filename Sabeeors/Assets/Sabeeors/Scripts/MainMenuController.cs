﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {
    public void Play()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    
}

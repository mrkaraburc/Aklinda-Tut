﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menubehaviour : MonoBehaviour {

    public void triggerMenuBehavior(int i)
    {
        switch (i)
        {
            default:
            case (0):
                SceneManager.LoadScene("Menu");
                break;
            case (1):
                Application.Quit();
                break;


        }
    }
}

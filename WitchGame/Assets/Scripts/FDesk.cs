﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FDesk : MonoBehaviour {

    public Text timerText;
    public int potionneed1, potionneed2, potionneed3, potionneed4, count;
    public bool start;
    public static float daytimer;

    /// <summary>
    /// This function is called at the start of the scene to initialise the first potions. For the starter level, we will only include the 2
    /// </summary>
    // Use this for initialization
    void Start () {
        //timerText.text = daytimer.ToString();
        potionneed1 = 1;
        potionneed2 = 2;
    }
	
	// Update is called once per frame
    /// <summary>
    /// This function will increment the timer
    /// </summary>
	void Update () {

        if(start == true)
        {
            daytimer = 0.0f;
            start = false;
        }

        else
        {

        }

        timerText.text = daytimer.ToString();
        daytimer += Time.deltaTime;

        /*if (daytimer <= 0)
        {
            SceneManager.LoadScene("UpgradeShop");
        }*/

        /*else
        {
            if (maintimer <= 0)
            {
                updatenum();
            }
        }*/
    }

    /*private void updatenum()
    {
        print("Works");
        //maintimer = 10.0f;
    }*/
}

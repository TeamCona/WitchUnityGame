using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FDesk : MonoBehaviour {

    public Text timerText, Potion1Text, Potion2Text, Potion3Text, Potion4Text;
    public static int potionneed1, potionneed2, potionneed3, potionneed4, day;
    public static float daytimer;

    /// <summary>
    /// This function is called at the start of the scene to initialise the first potions. For the starter level, we will only include the 2
    /// </summary>
    // Use this for initialization
    void Start ()
    {
        potions();
        updatepotion();
    }
	
	// Update is called once per frame
    /// <summary>
    /// This function will increment the timer and show it on the GUI
    /// </summary>
	void Update () {

        timerText.text = daytimer.ToString();
        daytimer += Time.deltaTime;

    }

    /// <summary>
    /// This function will check the day in game and make the potions needed for that day
    /// </summary>
    void potions()
    {
        day = 1;

        if (day == 1)
        {
            potionneed1 = 1;
            potionneed2 = 1;
            potionneed3 = 0;
            potionneed4 = 0;
        }

        if (day == 2)
        {
            potionneed1 = 2;
            potionneed2 = 3;
            potionneed3 = 2;
            potionneed4 = 0;
        }

        if (day == 3)
        {
            potionneed1 = 3;
            potionneed2 = 4;
            potionneed3 = 3;
            potionneed4 = 4;
        }
    }

    /// <summary>
    /// This function will add the amount of potions needed to the GUI
    /// </summary>
    void updatepotion()
    {
        Potion1Text.text = potionneed1.ToString();
        Potion2Text.text = potionneed2.ToString();
        Potion3Text.text = potionneed3.ToString();
        Potion4Text.text = potionneed4.ToString();
    }
}

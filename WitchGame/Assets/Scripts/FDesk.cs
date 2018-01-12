using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FDesk : MonoBehaviour {

    public Text timerText, Potion1Text, Potion2Text;
    public static int potionneed1, potionneed2, potionneed3, potionneed4, day;
    public static float daytimer;

    /// <summary>
    /// This function is called at the start of the scene to initialise the first potions. For the starter level, we will only include the 2
    /// </summary>
    // Use this for initialization
    void Start ()
    {
        updatepotion();
    }
	
	// Update is called once per frame
    /// <summary>
    /// This function will increment the timer
    /// </summary>
	void Update () {

        timerText.text = daytimer.ToString();
        daytimer += Time.deltaTime;
    }

    void updatepotion()
    {
        day = 1;

        if (day == 1)
        {
            potionneed1 = 1;
            potionneed2 = 1;

            Potion1Text.text = potionneed1.ToString();
            Potion2Text.text = potionneed2.ToString();

        }
    }
}

using System.Collections;
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
    void Start ()
    {

        potionneed1 = 1;
        potionneed2 = 2;
    }
	
	// Update is called once per frame
    /// <summary>
    /// This function will increment the timer
    /// </summary>
	void Update () {

        timerText.text = daytimer.ToString();
        daytimer += Time.deltaTime;

    }
}

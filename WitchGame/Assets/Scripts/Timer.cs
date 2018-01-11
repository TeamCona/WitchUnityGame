using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    //Variables needed for the timer
    public Text timerText;
    public float daytimer;

    // Use this for initialization
    /// <summary>
    /// Uses the static timer from the first scene 
    /// </summary>
    void Start ()
    {
        daytimer = FDesk.daytimer;
    }

    // Update is called once per frame
    /// <summary>
    /// The timer will increase her and the timer text will change. The main static variable containing the timer will also be changed 
    /// so it remains consistent between all the scenes.
    /// </summary>
    void Update ()
    {
        timerText.text = daytimer.ToString();
        daytimer += Time.deltaTime;
        FDesk.daytimer = daytimer;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FDesk : MonoBehaviour {

    public Text timerText;
    public int potionneed1, potionneed2;
    public float daytimer = 60.0f;

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
    /// This function is called everyframe and will use the floats initialised earlier to countdown until the either you may check for more potions or
    /// if the day ends
    /// </summary>
	void Update () {

        timerText.text = daytimer.ToString();
        daytimer -= Time.deltaTime;

        if (daytimer <= 0)
        {
            SceneManager.LoadScene("UpgradeShop");
        }

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
        maintimer = 10.0f;
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FDesk : MonoBehaviour {

    public Text timerText, Potion1Text, Potion2Text, Potion3Text, Potion4Text;
	public static int potionneed1, potionneed2, potionneed3, potionneed4 ;
	public static float day = 1;
	public static int time = 0;
	public static int cashmonay;
    public static float daytimer;
	public GameObject Potion, Potion2, Potion3, Potion4;

	//public Transform Potion;


    /// <summary>
    /// This function is called at the start of the scene to initialise the first potions. For the starter level, we will only include the 2
    /// </summary>
    // Use this for initialization
    void Start ()
    {
        //potions();
        updatepotion();
		Create ();
	}

	/// <summary>
	/// This function will create instances of the the potion. Each one is cloned from a prefab. The first two are automatically cloned, the other two only become
	/// availible if they are purchased in the upgrade shop.
	/// </summary>
	void Create()
	{
		GameObject po1 = (GameObject)Instantiate (Potion, new Vector3 (-7, -4, -1), Quaternion.identity);
		po1.name = "po1";
		GameObject po2 = (GameObject)Instantiate (Potion2, new Vector3 (-5, -4, -1), Quaternion.identity);
		po2.name = "po2";

		if (UpgradeShop.upgrade1 == 1) 
		{
			GameObject po3 = (GameObject)Instantiate (Potion3, new Vector3 (-3, -3, -1), Quaternion.identity);
			po3.name = "po3";
		}

		if (UpgradeShop.upgrade1 == 2) 
		{
			GameObject po3 = (GameObject)Instantiate (Potion3, new Vector3 (-3, -3, -1), Quaternion.identity);
			GameObject po4 = (GameObject)Instantiate (Potion4, new Vector3 (-1, -3, -1), Quaternion.identity);
			po3.name = "po3";
			po4.name = "po4";
		}
			
		Debug.Log ("Ins works");
	}
	// Update is called once per frame
    /// <summary>
    /// This function will increment the timer and show it on the GUI
    /// </summary>
	void Update () 
	{
		updatepotion();
        timerText.text = daytimer.ToString();
        daytimer += Time.deltaTime;
    }


    /// <summary>
    /// This function will check the day in game and make the potions needed for that day
    /// </summary>
    void potions()
    {
        //day = 1;

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
		if (time == 0) 
		{
			potions ();
		}
        Potion1Text.text = potionneed1.ToString();
        Potion2Text.text = potionneed2.ToString();
        Potion3Text.text = potionneed3.ToString();
        Potion4Text.text = potionneed4.ToString();
		finishlevel ();
		time++;
    }

	//public static bool dis = false;
	/// <summary>
	/// This funtion will check if the conditions are met to finish the level and if they are, will transition to the upgradeshop
	/// </summary>
	public void finishlevel()
	{

		//Checks the requirements are met
		if (potionneed1 == 0 && potionneed2  == 0 && potionneed3 == 0 && potionneed4 == 0)
		{
			//This variable allows the potions to be destroyed
			//dis = true;

			//This section allocate money to the player depending on how much time they took to complete the level
			if(daytimer < 120)
			{
				cashmonay += 3;
			}

			if (daytimer < 360 && daytimer > 120)
			{
				cashmonay += 2;
			}

			if (daytimer > 360)
			{
				cashmonay += 3;
			}

			//This section will give the user money depending on what level they were playing.
			if (FDesk.day == 1)
			{
				cashmonay += 10;
			}

			if (FDesk.day == 2)
			{
				cashmonay += 20;
			}

			if (FDesk.day == 3)
			{
				cashmonay += 30;
			}

			//Checks the button will work and transition to the next level
			Debug.Log("Works");
			SceneManager.LoadScene("UpgradeShop");

			//Reset the timer for the next day
			FDesk.daytimer = 0;
		}

		Debug.Log("Works");

	}
		
}

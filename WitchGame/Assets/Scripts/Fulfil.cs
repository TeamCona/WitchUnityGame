using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Fulfil : MonoBehaviour {

    public static int cashmonay;
    /// <summary>
    /// This funtion will check if the conditions are met to finish the level and if they are, will transition to the upgradeshop
    /// </summary>
	public void finishlevel()
    {
        //Checks the requirements are met
        if (FDesk.potionneed1 == 0 && FDesk.potionneed2  == 0 && FDesk.potionneed3 == 0 && FDesk.potionneed4 == 0)
        {
            //This section allocate money to the player depending on how much time they took to complete the level
            if(FDesk.daytimer < 120)
            {
                cashmonay += 3;
            }

            if (FDesk.daytimer < 360 && FDesk.daytimer > 120)
            {
                cashmonay += 2;
            }

            if (FDesk.daytimer > 360)
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
        }

        Debug.Log("Works");

        //Reset the timer for the next day
        FDesk.daytimer = 0;

    }
}

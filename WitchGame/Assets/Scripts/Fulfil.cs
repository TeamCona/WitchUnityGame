using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Fulfil : MonoBehaviour {

    /// <summary>
    /// This funtion will check if the conditions are met to finish the level and if they are, will transition to the upgradeshop
    /// </summary>
	public void finishlevel()
    {
        if (FDesk.potionneed1 == 0 && FDesk.potionneed2  == 0 && FDesk.potionneed3 == 0 && FDesk.potionneed4 == 0)
        {
            Debug.Log("Works");
            SceneManager.LoadScene("UpgradeShop");
        }

        Debug.Log("Works");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeShop : MonoBehaviour {

    Image PotionImage;

    public Sprite potion3;
    public Sprite potion4;
    
	// Use this for 
    /// <summary>
    /// Will automatically change the potion to match the day
    /// </summary>
	void Start ()
    {
        ChangePotion();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChangePotion()
    {
        if(FDesk.day == 2)
        {
            gameObject.GetComponent<Image>().sprite = potion3;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = potion4;
        }
    }
}

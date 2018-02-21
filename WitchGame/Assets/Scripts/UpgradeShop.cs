using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeShop : MonoBehaviour {

	//Sprites containing new potions to make
    public Sprite potion3;
    public Sprite potion4;

	//Text showing amounts of money on the GUI
	public Text MoneyText;
	public Text CostText1;
	public Text CostText2;

	//Amount of money owned and needed for purchases
	//public int money;
	public static int cost1;
	public static int cost2;
	public static int upgrade1 = 0 ; 
	public static int upgrade2 = 0 ;

	//public static int addPotions = 0;
    
	// Use this for 
    /// <summary>
    /// Will automatically change the potion to match the day
    /// </summary>
	void Start ()
    {
		FDesk.cashmonay = 10;
        ChangePotion();
		UpdateCost ();
		FDesk.time = 0;
	}

    /// <summary>
    /// Will check the day and will add the potion for use the next day
    /// </summary>
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

	/// <summary>
	/// Upgrades the cost if an item has been purchased
	/// </summary>
	void UpdateCost()
	{
		//Fulfil.cashmonay = 10;
		//Upgrade1
		if (upgrade1 < 1) 
		{
			cost1 = 4;
		}
		else 
		{
			cost1 = 7;
		}

		//Upgrade2
		if (upgrade2 < 1) 
		{
			cost2 = 5;
		}
		else 
		{
			cost2 = 9;
		}

		//Change cost text

		CostText1.text = cost1.ToString ();
		CostText2.text = cost2.ToString ();

		//Update money text

		MoneyText.text = FDesk.cashmonay.ToString();
	}

	int upgrade(int x)
	{
		int newcost;
		newcost = x + 1;
		Debug.Log (x + 1);
		Debug.Log (newcost);
		return newcost;
	}

	/// <summary>
	/// This upgrade will cut the time for potion making by a third and then a half by incrementing upgrade 2 which will affect code in the Cauldron script.
	/// </summary>
	public void BuyCal()
	{
		if (cost2 <= FDesk.cashmonay) 
		{
			FDesk.cashmonay = FDesk.cashmonay - cost2;
			upgrade2++;
			//upgrade2 = upgrade (upgrade2);
			Debug.Log (upgrade1);
			UpdateCost();
		}
	}

	/// <summary>
	/// This function will add an extra potion to the bar if there is enough money. By incrementing upgrade one variable, the front desk will instanciate
	/// another potion.
	/// </summary>
	public void BuySpace()
	{
		if (cost1 <= FDesk.cashmonay) 
		{
			FDesk.cashmonay = FDesk.cashmonay - cost1;
			upgrade1++;
			UpdateCost();
		}
	}
}

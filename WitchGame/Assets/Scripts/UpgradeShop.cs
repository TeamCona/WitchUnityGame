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
	public int cost1;
	public int cost2;
	public int upgrade1, upgrade2;

	public static int addPotions = 0;
    
	// Use this for 
    /// <summary>
    /// Will automatically change the potion to match the day
    /// </summary>
	void Start ()
    {
		//Example
		Fulfil.cashmonay = 10;
        ChangePotion();
		//UpdateMoney();
		UpdateCost ();
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
	/// Function will update the text that shows monwy availible
	/// </summary>
	//void UpdateMoney()
	//{
		//money = Fulfil.cashmonay;
	//	MoneyText.text = Fulfil.cashmonay.ToString();
	//}

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

		MoneyText.text = Fulfil.cashmonay.ToString();
	}

	/// <summary>
	/// Buys caldron upgrade
	/// </summary>
	public void BuyCal()
	{
		if (cost2 <= Fulfil.cashmonay) 
		{
			Fulfil.cashmonay = Fulfil.cashmonay - cost2;
			//TODO
			//Change caldron timer here
			upgrade2++;
			UpdateCost();
		}
	}

	public void BuySpace()
	{
		if (cost1 <= Fulfil.cashmonay) 
		{
			Fulfil.cashmonay = Fulfil.cashmonay - cost1;
			//TODO
			//Change space amount here

			upgrade1++;
			UpdateCost();
		}
	}
}

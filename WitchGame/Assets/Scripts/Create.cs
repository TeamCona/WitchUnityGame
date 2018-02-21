using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour {

	public GameObject Potion, Potion2, Potion3, Potion4;

	public bool cooked;
	static int seconds;
	public int potionType;
	public bool empty;
	public Sprite Empty, potion1, potion2, potion3, potion4, BadPotion;

	void Start()
	{
		Createpotions ();
	}

	void OnMouseUp()
	{
		//TODO
		//if ingredients.var1 == then po1. = 
	}
		

	void Createpotions()
	{


		/*
		GameObject po1 = (GameObject)Instantiate (Potion, new Vector3 (-7, -4, -1), Quaternion.identity);
		po1.name = "po1";
		GameObject po2 = (GameObject)Instantiate (Potion2, new Vector3 (-5, -4, -1), Quaternion.identity);
		po2.name = "po2";

		if (UpgradeShop.upgrade1 == 1) {
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

		if (gameObject.name == "po1") 
		{
			po1.GetComponent ("cooked") = true;
			Debug.Log ("Works");
		}*/
	}
}

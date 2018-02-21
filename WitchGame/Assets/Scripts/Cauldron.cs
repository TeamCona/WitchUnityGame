using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cauldron : MonoBehaviour {

	//Will change if the cauldron has been activated
	public static bool cooked = false;
	static int seconds;
	public static int potionType;

	//public Sprite Empty, Potion1, Potion2, Potion3, Potion4;

	static bool empty = true;
	public Sprite Empty, Potion1, Potion2, Potion3, Potion4, BadPotion;

	/// <summary>
	/// This fuction will check when the mouse has ben clicked which scene th user is in. If thyre in the cauldron scene, the cauldron fucnction will be called.
	/// </summary>
	void OnMouseUp()
	{

		//return name of this scene
		string sceneName = SceneManager.GetActiveScene().name;

		//TODO
		//Remove this and set variable in ingredients
		//potionType = 2;



		//Check the name of the scene and call functions relevant to it
		if (sceneName == "Cauldron") 
		{
			Debug.Log ("Cauldron Scene");
			CauldronOn ();
		}
		if (sceneName == "FDesk") 
		{
			Debug.Log ("Front desk");
			DeliverItem ();
			//Debug.Log (transform.position);
		}

	}

	/// <summary>
	/// This will check if the object is in the correct space and if it's finished going through the process. If so it will remove on from the potion
	/// needed, will change the sprite to an empty potion and will set cooke, the varivle that checks if the process has been followed to false again.
	/// </summary>
	void DeliverItem()
	{
		if (transform.position.x > 4.4 && transform.position.x < 5.3) 
		{

			Debug.Log (transform.position);
			if (transform.position.y < 3.4 && transform.position.y > 2.4) 
			{
				if (cooked == true) {
					if (potionType == 1) 
					{
						FDesk.potionneed1--;
					}
					if (potionType == 2) 
					{
						FDesk.potionneed2--;
					}
					if (potionType == 3) 
					{
						FDesk.potionneed3--;
					}
					if (potionType == 4) 
					{
						FDesk.potionneed4--;
					}

					this.gameObject.GetComponent<SpriteRenderer> ().sprite = Empty;
					cooked = false;

				}

				transform.position = new Vector3 (-7, -4, -1);
			}
		}
	}

	/// <summary>
	/// This function will check if the object is in the correct space. If so it will change the location of the potion to be more central and 
	/// then call Cauldron time.
	/// </summary>
	void CauldronOn()
	{
		//Checks if the potion is in the cauldron space
		if (transform.position.x > -3 && transform.position.x < 0)
		{
			if (transform.position.y < 2 && transform.position.y > 0) 
			{
				Debug.Log ("Cauldron");
				//Cal = true;
				transform.position = new Vector3 (-2, 1, 0);
				StartCoroutine (CauldronTime ());
			}
		}
	}


	/// <summary>
	/// This function will check for cauldron upgrades and cook a potionfor a certain amount of time. It will also change the sprite.
	/// </summary>
	/// <returns>The time.</returns>
	public IEnumerator CauldronTime()
	{
		potionType = 5;

		//This will determine how long the caulfron will take depending on upgrades. Upgrade2 will increment in upgrade shop if money is spent.
		if (UpgradeShop.upgrade2 == 1) 
		{
			seconds = 2;
		}

		if (UpgradeShop.upgrade2 == 2) 
		{
			seconds = 1;
		}

		else 
		{
			seconds = 3;
		}
			
		//this will check which potion has been made, how long to cook it and what sprite will be shown before putting it back on the bottom bar.
		if (potionType == 1) 
		{
			yield return new WaitForSeconds (seconds*1);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion1;
		}

		if (potionType == 2) 
		{
			yield return new WaitForSeconds (seconds*2);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion2;
		}

		if (potionType == 3)
		{
			yield return new WaitForSeconds (seconds*3);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion3;
		}
		if(potionType == 4)
		{
			yield return new WaitForSeconds (seconds*4);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion4;
		}
		if (potionType == 5) 
		{
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = BadPotion;

		}
							
		cooked = true;
		transform.position = new Vector3 (-7, -4, -1);

	}
}

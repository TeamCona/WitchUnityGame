using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cauldron : MonoBehaviour {

	//Will change if the cauldron has been activated
	public bool cooked;
	static int seconds;
	public bool empty;
	public static int potionType1, potionType2, potionType3, potionType4;

	//public Sprite Empty, Potion1, Potion2, Potion3, Potion4;

	public Sprite Empty, Potion1, Potion2, Potion3, Potion4, BadPotion;

	/// <summary>
	/// This fuction will check when the mouse has ben clicked which scene th user is in. If thyre in the cauldron scene, the cauldron fucnction will be called.
	/// </summary>
	void OnMouseUp()
	{

		//return name of this scene
		string sceneName = SceneManager.GetActiveScene().name;

		Debug.Log (gameObject.name);

		if (gameObject.name == "po1")
		{
			Debug.Log ("po one");
			Create.potionType1++;
			Debug.Log (Create.potionType1);
		} 

			
		//TODO
		//Remove this and set variable in ingredients
		//potionType = 2;



		//Check the name of the scene and call functions relevant to it
		if (sceneName == "Cauldron") 
		{
			Debug.Log ("Cauldron Scene");
			Debug.Log (gameObject.name);
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
				//if (gameObject.name == "po1") 
				//{
				if (potionType1 == 1 || potionType2 == 1 || potionType3 == 1 || potionType4 == 1 ) 
					{
						FDesk.potionneed1--;
					}
				if (potionType1 == 2 || potionType2 == 2 || potionType3 == 2 || potionType4 == 2 ) 
					{
						FDesk.potionneed2--;
					}
				if(potionType1 == 3 || potionType2 == 3 || potionType3 == 3 || potionType4 == 3 )
					{
						FDesk.potionneed3--;
					}
				if (potionType1 == 4 || potionType2 == 4 || potionType3 == 4 || potionType4 == 4 )
					{
						FDesk.potionneed4--;
					}

						this.gameObject.GetComponent<SpriteRenderer> ().sprite = Empty;
						cooked = false;
					}

				transform.position = new Vector3 (-7, -4, -1);
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
		potionType1 = 2;

		//if(gameObject.name == "po1")


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
		if (potionType1 == 1 || potionType2 == 1 || potionType2 == 1 || potionType3 == 1) 
		{
			yield return new WaitForSeconds (seconds*1);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion1;
		}
			
		if (potionType1 == 2 || potionType2 == 2 || potionType3 == 2 || potionType4 == 2) 
		{
			yield return new WaitForSeconds (seconds*2);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion2;
		}

		if (potionType1 == 3 || potionType2 == 3 || potionType2 == 3 || potionType3 == 3)
		{
			yield return new WaitForSeconds (seconds*3);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion3;
		}
		if(potionType1 == 4 || potionType2 == 4 || potionType2 == 4 || potionType3 == 4)
		{
			yield return new WaitForSeconds (seconds*4);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion4;
		}
		if (potionType1 == 5 || potionType2 == 5 || potionType2 == 5 || potionType3 == 5) 
		{
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = BadPotion;

		}
							
		this.transform.position = new Vector3 (-7, -4, -1);

	}
}

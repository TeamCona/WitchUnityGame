using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cauldron : MonoBehaviour {

	//Will change if the cauldron has been activated
	static bool Cal = false;
	static int slot;
	static int potionType;
	public Sprite Potion1, Potion2, Potion3, Potion4;

	void Start()
	{
		//Create temporary reference to the current scene
		 //Scene currentscene = SceneManager.GetActiveScene();
	}

	/// <summary>
	/// This fuction will check when the mouse has ben clicked which scene th user is in. If thyre in the cauldron scene, the cauldron fucnction will be called.
	/// </summary>
	void OnMouseUp()
	{

		//return name of this scene
		string sceneName = SceneManager.GetActiveScene().name;

		if (sceneName == "Cauldron") 
		{
			Debug.Log ("Cauldron Scene");
			CauldronOn ();
		}
		else
		{
			Debug.Log ("Not cauldron scene");
		}
	}

	void CauldronOn()
	{
		//if(GameObject.Find("Potion").transform.position
		//Vector3 p = transform.position;
		//Debug.Log(p);
		float timeLeft = 100;

		//Checks if the potion is in the cauldron space
		if (transform.position.x > -3 && transform.position.x < 0) {
			if (transform.position.y < 2 && transform.position.y > 0) {
				Debug.Log ("Cauldron is on bitches");
				Cal = true;
				transform.position = new Vector3 (-2, 1, 0);
				StartCoroutine (CauldronTime ());

				//yield return new WaitForSeconds (10);

				/*while (Cal == true) 
				{
					if (timeLeft > 0) 
					{
						timeLeft -= Time.deltaTime;
						Debug.Log (timeLeft);
					}
					else 
					{
						Cal = false;
						Debug.Log ("Try to move");
					}
				}*/
			}
		}
	}

	public IEnumerator CauldronTime()
	{
		//potionType = "Second potion";
		potionType = 1;

		if (potionType == 1) 
		{
			yield return new WaitForSeconds (2);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion1;
		}

		if (potionType == 2) 
		{
			yield return new WaitForSeconds (2);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion2;
		}

		if (potionType == 3)
		{
			yield return new WaitForSeconds (2);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion3;
		}
		if(potionType == 4)
		{
			yield return new WaitForSeconds (2);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Potion4;
		}

		transform.position = new Vector3 (-7, -4, -1);

	}
}

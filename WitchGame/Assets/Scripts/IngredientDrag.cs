using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientDrag : MonoBehaviour {

	public GameObject ingredients;
	float distance = 15;

	private GameObject[] getFeatherCount;
	private int countFeather = 0;

	private GameObject[] getFWingCount;
	private int countFWing = 0;

	private GameObject[] getUHornCount;
	private int countUHorn = 0;

	private GameObject[] getDScalesCount;
	private int countDScales = 0;

	private GameObject[] getVBloodCount;
	private int countVBlood = 0;

	/// <summary>
	/// Raises the mouse down event.
	/// Locates the tag of the game object and instansiates 
	/// the chosen object
	/// </summary>
	void OnMouseDown()
	{ 
		if (gameObject.tag == "Feather") 
		{
			ingredients = GameObject.FindGameObjectWithTag ("Feather");
			Instantiate (ingredients, transform.position, transform.rotation);

		}

		if (gameObject.tag == "FairyWings") 
		{
			ingredients = GameObject.FindGameObjectWithTag ("FairyWings");
			Instantiate (ingredients, transform.position, transform.rotation);
		}

		if (gameObject.tag == "UnicornHorn") 
		{
			ingredients = GameObject.FindGameObjectWithTag ("UnicornHorn");
			Instantiate (ingredients, transform.position, transform.rotation);
		}

		if (gameObject.tag == "DragonScales") 
		{
			ingredients = GameObject.FindGameObjectWithTag ("DragonScales");
			Instantiate (ingredients, transform.position, transform.rotation);
		}

		if (gameObject.tag == "VampireBlood") 
		{
			ingredients = GameObject.FindGameObjectWithTag ("VampireBlood");
			Instantiate (ingredients, transform.position, transform.rotation);
		}
	}

	/// <summary>
	/// Raises the mouse drag event.
	/// Enables user to drag object around screen
	/// </summary>
    void OnMouseDrag()
	{
		//Need to save previous Position
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;
	}
		
	/// <summary>
	/// Raises the mouse up event.
	/// Once the mouse button lifts up
	/// The object is dropped into the mixing bowl
	/// </summary>
	void OnMouseUp()
	{
		transform.position = new Vector3 (0, 0, 0);
	}

	/// <summary>
	/// Adds sum of each single gameObject
	/// and displays it back once button is pushed
	/// </summary>
	public void SumOfIngredients()
	{
		getFeatherCount = GameObject.FindGameObjectsWithTag ("Feather");
		countFeather = getFeatherCount.Length;
		countFeather = countFeather - 1;
		Debug.Log ("Pheonix Feathers : " + countFeather);


		getFWingCount = GameObject.FindGameObjectsWithTag ("FairyWings");
		countFWing = getFWingCount.Length;
		countFWing = countFWing - 1;
		Debug.Log ("Fairy Wings : " + countFWing);


		getUHornCount = GameObject.FindGameObjectsWithTag ("UnicornHorn");
		countUHorn = getUHornCount.Length;
		countUHorn = countUHorn - 1;
		Debug.Log ("Unicorn Horn : " + countUHorn); 


		getDScalesCount = GameObject.FindGameObjectsWithTag ("DragonScales");
		countDScales = getDScalesCount.Length;
		countDScales = countDScales - 1;
		Debug.Log ("Dragon Scales : " + countDScales); 


		getVBloodCount = GameObject.FindGameObjectsWithTag ("VampireBlood");
		countVBlood = getVBloodCount.Length;
		countVBlood = countVBlood - 1;
		Debug.Log ("Vampire Blood : " + countVBlood); 

	}
		
}

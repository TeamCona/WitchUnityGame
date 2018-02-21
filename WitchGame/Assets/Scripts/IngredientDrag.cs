using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientDrag : MonoBehaviour {

	public GameObject ingredients;
	private int i;
	float distance = 15;

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
		//Sets to middle position
		transform.position = new Vector3 (0, 0, 0);
	}

	//The ingredient has been dropped into the cauldron
	void OnTriggerEnter2D()
	{
		Debug.Log ("Trigger touched");
	}

	void OnTriggerStay2D()
	{
		Debug.Log ("Still touching");
	}

	void OnTriggerExit2D()
	{
		Debug.Log ("Exit");
	}
		
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientDrag : MonoBehaviour {

    //Variables for the navigation buttons
	public GameObject ingredients;
	private int i;

	float distance = 15;

	void Start()
	{
		
	}

	void OnMouseDown()
	{ 
		if (gameObject.tag == "Feather") 
		{
			ingredients = GameObject.FindGameObjectWithTag ("Feather");
			Instantiate (ingredients, transform.position, transform.rotation);
		}
	}
    void OnMouseDrag()
	{
		//Need to save previous Position
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;
	}
		

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientDrag : MonoBehaviour {

    //Variables for the navigation buttons
    public Texture cal;
    public Texture ing;

    //This section is used to enable the drag feature
    float distance = 10;

	void OnMouseDrag()
	{
		//Need to save previous Position
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;
	}

	//The ingredient is dropped with no collision
	private Vector3 prevPosition;
	private Transform ingredient;

	void OnMouseUp()
	{
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

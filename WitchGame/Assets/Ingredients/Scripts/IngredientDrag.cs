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

<<<<<<< HEAD
    private void OnGUI()
    {
        //Create the buttons that will change the scene or location of the game
        //Directs user to the caldron using a picture
        if (GUI.Button(new Rect(Screen.width * .75f, 0, Screen.width * .2f, Screen.height * .1f), cal, ""))
        {
            //This button will load the test scene
            print("Kitchen Button works");
            Application.LoadLevel(1);
        }

        //Direscts user to ingredients using a picture
        if (GUI.Button(new Rect(Screen.width * .5f, 0, Screen.width * .2f, Screen.height * .1f), ing, ""))
        {
            //This button will load the scene containing the ingredients
            print("Ingredients Button works");
            Application.LoadLevel(2);
        }
    }
=======
>>>>>>> e3e77d4627e1e4dac1616bfd7ddd8e26752fd7b6
}

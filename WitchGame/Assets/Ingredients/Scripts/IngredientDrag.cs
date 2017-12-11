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
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

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
}

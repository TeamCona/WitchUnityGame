using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cauldron : MonoBehaviour {

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
		Vector3 p = transform.position;
		Debug.Log(p);
		//Coordinateds of the cauldron
		//Top left
		//-3, 2, 0
		//Top right
		//0, 2, 00
		//Bottom left
		//-3, 0, 0 
		// Bottom right
		//0.1, 0.2, 0
	}
}

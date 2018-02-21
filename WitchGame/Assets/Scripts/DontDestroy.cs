using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour {

	/// <summary>
    /// This function will add the looping music to the game
    /// </summary>
	void Awake ()
    {
        //Function will find objects that were tagged and will destroy one to prevent 2 songs playing at once 
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Potion");

		if (UpgradeShop.upgrade1 == 0) 
		{
			if (objs.Length > 2)
			{
				Destroy (this.gameObject);
			} 
			else
			{
				//Allows the music to keep looping
				DontDestroyOnLoad (this.gameObject);
			}
		}
		if (UpgradeShop.upgrade1 == 1) 
		{
			if (objs.Length > 3)
			{
				Destroy (this.gameObject);
			} 
			else
			{
				//Allows the music to keep looping
				DontDestroyOnLoad (this.gameObject);
			}
		}
		if (UpgradeShop.upgrade1 == 2) 
		{
			if (objs.Length > 4)
			{
				Destroy (this.gameObject);
			} 
			else
			{
				//Allows the music to keep looping
				DontDestroyOnLoad (this.gameObject);
			}
		}

	}

	void OnEnable()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnDisable()
	{
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		// here you can use scene.buildIndex or scene.name to check which scene was loaded
		if (scene.name == "UpgradeShop"){
			// Destroy the gameobject this script is attached to
			Destroy(gameObject);
		}
	}
	
	
}

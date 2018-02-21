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
        //Function will find objects that were tagged and will destroy one to prevent more potions than have been bought appearing 
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Potion");

		//If upgrades have been bought, there will only be two potions but more will be allowed later
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


	/// <summary>
	/// Raises the enable event and allows objects to remain.
	/// </summary>
	void OnEnable()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	/// <summary>
	/// Raises the disable event and stops this code from running.
	/// </summary>
	void OnDisable()
	{
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	/// <summary>
	/// Destroys objects if the upgrade scene has opened.
	/// </summary>
	/// <param name="scene">Scene.</param>
	/// <param name="mode">Mode.</param>
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		// here you can use scene.buildIndex or scene.name to check which scene was loaded
		if (scene.name == "UpgradeShop"){
			// Destroy the gameobject this script is attached to
			Destroy(gameObject);
		}
	}
	
	
}

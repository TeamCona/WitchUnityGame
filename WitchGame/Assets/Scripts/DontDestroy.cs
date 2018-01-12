using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

	/// <summary>
    /// This function will add the looping music to the game
    /// </summary>
	void Awake ()
    {
        //Function will find objects that were tagged and will destroy one to prevent 2 songs playing at once 
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        //Allows the music to keep looping
        DontDestroyOnLoad(this.gameObject);
	}
	
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This script will be used in the work day scenes to allow the player to switch between screens
/// </summary>

public class LoadOnclick : MonoBehaviour {

    /// <summary>
    /// This function will activate when a button is clicked. The button will then pass the name of the scene it will load into scenemanger
    /// which will change the scene
    /// </summary>
    /// <param name="scenename"></param>
	public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switchscenes : MonoBehaviour {

	public void PlayGame()
	{
		SceneManager.LoadScene ("Scenes/FDesk");
	}

	public void Instructions()
	{

	}

	public void ExitGame()
	{
		Debug.Log ("Quit");
		Application.Quit ();
	}

}

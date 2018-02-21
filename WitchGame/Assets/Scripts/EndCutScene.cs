using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCutScene : MonoBehaviour {

	public GameObject montyDeter;
	public GameObject montyShock;
	public GameObject catMShock;
	public GameObject catMSick;
	public GameObject catM;
	public GameObject Mona;
	public int scene = 0;

	/// <summary>
	/// Start this instance.By setting all characters
	/// invisable.
	/// </summary>
	void Start () 
	{
		montyDeter = GameObject.FindGameObjectWithTag ("MontyDeter");
		montyDeter.SetActive (false);

		montyShock = GameObject.FindGameObjectWithTag ("MontyShock");
		montyShock.SetActive (false);

		catMShock = GameObject.FindGameObjectWithTag ("CatM_Shock");
		catMShock.SetActive (false);

		catMSick = GameObject.FindGameObjectWithTag ("SickCat");
		catMSick.SetActive (false);

		catM = GameObject.FindGameObjectWithTag ("CatM");
		catM.SetActive (false);

		Mona = GameObject.FindGameObjectWithTag ("Mona");
		Mona.SetActive (false);
	}
	
	/// <summary>
	/// Startings the scene.By Monty appearing
	/// </summary>
	public void StartingScene()
	{
		Mona.SetActive (true);
		scene = 1;
		Debug.Log ("Scene : " + scene);

		scene = 2;
	}

	/// <summary>
	/// Scene sequence starts characters appear
	/// and dissapear when needed.
	/// </summary>
	public void Scenes()
	{
		if (scene == 2) 
		{
			catM.SetActive (true);
			Debug.Log ("Scene : " + scene);
		}
		else
		if (scene == 3) 
		{
			catM.SetActive (false);
			catMSick.SetActive (true);
			Debug.Log ("Scene : " + scene);
		}
		if (scene == 4) 
		{
			Debug.Log ("Scene : " + scene);
		}
		if (scene == 5) 
		{
			Debug.Log ("Scene : " + scene);
		}
		if (scene == 6) 
		{
			Debug.Log ("Scene : " + scene);
		}
		if (scene == 7) 
		{
			Debug.Log ("Scene : " + scene);
		}
		if (scene == 8) 
		{
			Debug.Log ("Scene : " + scene);
		}
		if (scene == 9) 
		{
			SceneManager.LoadScene ("Credit");
			Debug.Log ("Scene : " + scene);
		}

		scene++; 
	}
}

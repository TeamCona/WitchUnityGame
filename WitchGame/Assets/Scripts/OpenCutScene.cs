using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCutScene : MonoBehaviour {

	public GameObject montyDeter;
	public GameObject montyShock;
	public GameObject catMShock;
	public GameObject catM;
	public GameObject Mona;
	public int scene = 0;

	/// <summary>
	/// Start this instance.By setting all characters
	/// invisable.
	/// </summary>
	void Start()
	{
		montyDeter = GameObject.FindGameObjectWithTag ("MontyDeter");
		montyDeter.SetActive (false);

		montyShock = GameObject.FindGameObjectWithTag ("MontyShock");
		montyShock.SetActive (false);

		catMShock = GameObject.FindGameObjectWithTag ("CatM_Shock");
		catMShock.SetActive (false);

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
		montyDeter.SetActive (true);
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
			montyDeter.SetActive (false);
			montyShock.SetActive (true);
			Debug.Log ("Scene : " + scene);
		}
		else
		if (scene == 3) 
		{
			catMShock.SetActive (true);
			montyShock.SetActive (false);
			Debug.Log ("Scene : " + scene);
		}
		if (scene == 4) 
		{
			catMShock.SetActive (true);
			Debug.Log ("Scene : " + scene);
		}
		if (scene == 5) 
		{
			catMShock.SetActive (true);
			Debug.Log ("Scene : " + scene);
		}
		if (scene == 6) 
		{
			catMShock.SetActive (false);
			Mona.SetActive(true);
			catM.SetActive (true);
			Debug.Log ("Scene : " + scene);
		}

		scene++;
	}
}

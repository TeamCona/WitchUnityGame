using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookDisplay : MonoBehaviour
{
	public void OnMouseDown()
	{
		SceneManager.LoadScene("Scenes/OpenBook");
		Debug.Log ("Works");
	}
}

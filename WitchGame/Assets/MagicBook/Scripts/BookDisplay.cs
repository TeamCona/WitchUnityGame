using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookDisplay : MonoBehaviour
{
	public void OnMouseDown()
	{
		//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		SceneManager.LoadScene("MagicBook/OpenBook");
		Debug.Log ("Works");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishDayClick : MonoBehaviour 
{
	/// <summary>
	/// This fuction will check conditions when the button has been clicked.
	/// If the game is over it will change to the cutscene 
	/// If not it will increment the day count and go back to the front desk scene
	/// </summary>
	public void FinishDay()
	{
		if (FDesk.day == 3) 
		{
			Debug.Log ("Add ending cutsene here");
		} 

		else 
		{
			Debug.Log ("Day thing works");
			FDesk.day++;
			SceneManager.LoadScene("FDesk");
		}
	}
}

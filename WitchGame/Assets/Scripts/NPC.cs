using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {

	/// <summary>
	/// Connects the trigger and the
	/// converation together
	/// </summary>
	public Chat chat;
	public GameObject beginButton;
	public GameObject monty;

	/// <summary>
	/// Removes the button.
	/// </summary>
	public void RemoveButton()
	{
		Destroy(beginButton.gameObject);
	}

	/// <summary>
	/// Triggers the conversation.
	/// </summary>
	public void TriggerConversation()
	{
		
		FindObjectOfType<ChatManager>().StartChat(chat);
	}

	public void StartAnimation()
	{
		if (gameObject.tag == "MontyDeter") 
		{
			monty = GameObject.FindGameObjectWithTag ("MontyDeter");
			Instantiate (monty, transform.position, transform.rotation);

			//monty = new Vector3(5.5, 1.2, 0);
		}
	}
}

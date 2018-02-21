using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {

	public Chat chat;
	public GameObject beginButton;

	/// <summary>
	/// Triggers the conversation.
	/// </summary>
	public void TriggerConversation()
	{
		FindObjectOfType<ChatManager>().StartChat(chat);
	}

	/// <summary>
	/// Removes the button.
	/// </summary>
	public void RemoveButton()
	{
		beginButton = GameObject.FindGameObjectWithTag ("BeginButton");
		beginButton.SetActive (false);
	}
		
}

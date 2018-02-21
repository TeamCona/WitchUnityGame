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

	public void RemoveButton()
	{
		beginButton = GameObject.FindGameObjectWithTag ("BeginButton");
		//Destroy(beginButton.gameObject);
		beginButton.SetActive (false);
	}
		
}

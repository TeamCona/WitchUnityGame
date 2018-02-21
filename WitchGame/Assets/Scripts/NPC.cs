using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {

	/// <summary>
	/// Connects the trigger and the
	/// converation together
	/// </summary>
	public Chat chat;


	/*void Start()
	{
		TriggerConversation ();
	}*/

	public void TriggerConversation()
	{
		FindObjectOfType<ChatManager>().StartChat(chat);
	}

}

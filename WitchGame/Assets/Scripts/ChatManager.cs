using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatManager : MonoBehaviour {

	private Queue<string> sentences;

	/// <summary>
	/// Initializing new queue of
	/// sentences
	/// </summary>
	void Start () {
		sentences = new Queue<string> ();
	}

	public void StartChat(Chat chat)
	{
		Debug.Log ("Starting chat" + chat.name);
	}

}

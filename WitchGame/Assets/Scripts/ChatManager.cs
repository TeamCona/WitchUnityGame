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

	/// <summary>
	/// Clears sentences
	/// Then Enqueues the next sentence to be used
	/// </summary>
	/// <param name="chat">Chat.</param>
	public void StartChat(Chat chat)
	{
		Debug.Log ("Starting chat" + chat.name);


		sentences.Clear ();

		foreach (string sentence in chat.sentences) {
			sentences.Enqueue (sentence);
		}

		DisplayNextSentence ();
	}

	public void DisplayNextSentence()
	{
		if (sentences.Count == 0) {
			EndChat ();
			return;
		}

		string sentence = sentences.Dequeue ();
		Debug.Log (sentence);
	}

	/// <summary>
	/// Ends the chat.
	/// </summary>
	void EndChat()
	{
		Debug.Log ("Chat ended");
	}

}

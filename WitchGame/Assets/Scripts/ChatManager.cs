using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChatManager : MonoBehaviour {

	public Text nameText;
	public Text chatText;

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

		nameText.text = chat.name;
		sentences.Clear ();

		foreach (string sentence in chat.sentences) {
			sentences.Enqueue (sentence);
		}

		DisplayNextSentence ();
	}

	/// <summary>
	/// Displays the next sentence.
	/// </summary>
	public void DisplayNextSentence()
	{
		if (sentences.Count == 0) {
			EndChat ();
			return;
		}

		string sentence = sentences.Dequeue ();

		///<summary>
		/// This makes sure that the sentences arent overlapping
		/// </summary>
		StopAllCoroutines ();
		StartCoroutine (TypeSentence (sentence));
	}

	/// <summary>
	/// This section shows letters one by one
	/// </summary>
	/// <returns>The sentence.</returns>
	/// <param name="sentence">Sentence.</param>
	IEnumerator TypeSentence(string sentence)
	{
		chatText.text = "";
		foreach (char letter in sentence.ToCharArray()) {
			chatText.text += letter;
			yield return null;
		}
	}

	/// <summary>
	/// Ends the chat.
	/// </summary>
	void EndChat()
	{
		SceneManager.LoadScene ("Scenes/FDesk");
		Debug.Log ("Chat ended");
	}

}

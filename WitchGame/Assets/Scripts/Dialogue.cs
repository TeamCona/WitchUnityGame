using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue : MonoBehaviour {

	public string name;

	/// <summary>
	/// Text area increases length of
	/// sentences that can be written.
	///  </summary>
	[TextArea(3, 10)]
	public string[] sentences;
}

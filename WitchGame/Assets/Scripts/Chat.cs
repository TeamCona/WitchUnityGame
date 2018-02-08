using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enables chat editing in unity
/// </summary>
[System.Serializable]
public class Chat {

	public string name;

	[TextArea(3,10)]
	public string[] sentences;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions : MonoBehaviour {

	public static Potions i;

	void Awake()
	{
		if (!i) {
			i = this;
			DontDestroyOnLoad(gameObject);
		} 
		else
		{
			Destroy (gameObject);
		}
			
	}
}

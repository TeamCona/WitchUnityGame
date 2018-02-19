using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PotionTest : MonoBehaviour {

	public Sprite Empty;
	public Sprite Full;
	public Transform Potion;


	/*float timer = 1f;
	float delay = 1f;*/

	void Start()
	{
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = Empty;
	}

	void Create()
	{
		//Instantiate (Potion, new Vector3 (0, -0, -1), Quaternion.identity);
		Debug.Log ("Instanciate Works");
	}

	/*void Update()
	{
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Empty) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Full;
				timer = delay;
				return;
			}
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Full) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Empty;
				timer = delay;
				return;
			}
		}

	}*/

	//This section is used to enable the drag feature
	float distance = 10;

	void OnMouseDrag()
	{
		//Need to save previous Position
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;

		Debug.Log ("Drag should work");
	}
}
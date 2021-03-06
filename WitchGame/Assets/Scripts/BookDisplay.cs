﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BookDisplay : MonoBehaviour
{
    public Text timerText;
    public float daytimer;

    private void Start()
    {
        daytimer = FDesk.daytimer;
    }

    private void Update()
    {
        timerText.text = daytimer.ToString();
        daytimer += Time.deltaTime;
        FDesk.daytimer = daytimer;
    }

	/// <summary>
	/// This will open the book for the user when they click
	/// </summary>
    public void OnMouseDown()
	{
		SceneManager.LoadScene("Scenes/OpenBook");
		Debug.Log ("Works");
	}
}

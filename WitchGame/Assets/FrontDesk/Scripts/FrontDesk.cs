using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script will be attatched to the frontdesk scene and the main camera
/// </summary>

public class FrontDesk : MonoBehaviour {

    public Texture backgroundtexture ;
    public Texture cal;

    private void OnGUI()
    {
        ///Display the texture created for the front desk
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundtexture);

        //Create the buttons that will change the scene or location of the game
        //First button
        //This one uses a string
        if (GUI.Button (new Rect(Screen.width *.5f, 0, Screen.width * .2f, Screen.height* .1f), "Ingredients"))
        {
            print("Ingredients Button works");
        }

        //Second button
        //This one works without a gui outline meaning it uses a picture instead of a string
        //Uses temporary picture
        if (GUI.Button (new Rect(Screen.width * .75f, 0, Screen.width * .2f, Screen.height * .1f),cal, ""))
        {
            print("Kitchen Button works");
        }
    }


}

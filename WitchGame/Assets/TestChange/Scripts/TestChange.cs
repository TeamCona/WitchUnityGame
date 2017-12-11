using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChange : MonoBehaviour
{
    //Variable for the navigation buttons and background
    public Texture backgroundtexture;
    public Texture cal;
    public Texture ing;

    private void OnGUI()
    {
        ///Display the texture created for the front desk
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundtexture);

        //Create the buttons that will change the scene or location of the game
        //Directs user to the caldron using a picture
        if (GUI.Button(new Rect(Screen.width * .75f, 0, Screen.width * .2f, Screen.height * .1f), cal, ""))
        {
            //This button will load the test scene
            print("Kitchen Button works");
            Application.LoadLevel(1);
        }

        //Direscts user to ingredients using a picture
        if (GUI.Button(new Rect(Screen.width * .5f, 0, Screen.width * .2f, Screen.height * .1f), ing, ""))
        {
            //This button will load the scene containing the ingredients
            print("Ingredients Button works");
            Application.LoadLevel(2);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChange : MonoBehaviour
{

    public Texture backgroundtexture;

    private void OnGUI()
    {
        ///Display the texture created for the front desk
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundtexture);
    }
}
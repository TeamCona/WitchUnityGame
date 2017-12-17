using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FDesk : MonoBehaviour {

    public int potionneed1, potionneed2;
    public float maintimer = 10.0f;

    // Use this for initialization
    void Start () {

        potionneed1 = 1;
        potionneed2 = 2;
    }
	
	// Update is called once per frame
	void Update () {
        maintimer -= Time.deltaTime;

        if (maintimer <= 0)
        {
            updatenum();
        }
    }

    private void updatenum()
    {
        print("Works");
        maintimer = 10.0f;
    }
}

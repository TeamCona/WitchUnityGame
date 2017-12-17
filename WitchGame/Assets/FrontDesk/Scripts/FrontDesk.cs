using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDesk : MonoBehaviour
{
    public int num;
    public float maintimer = 10.0f;

    private void Start()
    {
        num = 0;
    }

    private void Update()
    {
        maintimer -= Time.deltaTime;

        if(maintimer <= 0)
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

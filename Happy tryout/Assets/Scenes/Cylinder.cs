using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public float floatValue = 12.3f;
    public int intValue = 47;
    public string stringValue = "Cheese";


    //When it ENTERS sphere, it causes message.
    public void OnTriggerEnter(Collider other)
    {
        print("What does this one do?");
    }

    //When it EXITS sphere, it causes message.
    public void OnTriggerExit(Collider other)
    {
        print("So, does this make message when it goes through?");
    }

    //Creates message when hitting sphere AND the message continues if left in sphere. Over and over.
    public void OnTriggerStay(Collider other)
    {
        print("This will be an interesting one.");
    }
}




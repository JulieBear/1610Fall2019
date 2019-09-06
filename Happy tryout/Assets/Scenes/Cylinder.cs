//Note to Professor (I'll ask you personally as well), I am not quite understanding how 
//to make certain events happen. Such as that particle explosion. I've tried replicating
//what you showed us on Tuesday, but no matter how many times I try, it just isn't working.
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

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

    // Asking for return type, unsure of what that is, ask professor.
    //public MouseExitWindowEvent()
    //{
     //   print("leave and come back");
   // }

    //Creates message when hitting sphere AND the message continues if left in sphere. Over and over.
    //public void OnTriggerStay(Collider other)
    //{
      //  print("This will be an interesting one.");
    //}

    
    // Couldn't get this one to do anything, as I suspected with the particle part.
    //public void OnParticleTrigger()
    //{
      //  print("this might not do anything.");
    //}

    // So keycode can be used for many different keys.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            print("would this do something?");
    }
    
    
}




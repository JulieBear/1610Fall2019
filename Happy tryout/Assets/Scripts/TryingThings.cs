using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TryingThings : MonoBehaviour
{
    public bool running = true;
    public int dex = 3;
    public UnityEvent damage;
    public UnityEvent quit;
    public int stop = 1;
    public float time = 3f;
    private WaitForSeconds secsObj;

    private void Start()
    {
        secsObj = new WaitForSeconds(time);
    }

    //public void OnTriggerStay(Collider other)
    //{
    //	damage.Invoke();
    //}

    IEnumerator OnTriggerStay(Collider other)
    {
        while (dex > 0)
        {
            yield return new WaitForSeconds(3f);
            damage.Invoke();
            dex--;
        }

    }


    IEnumerator OnTriggerExit(Collider other)
    {
        while (stop > 0)
        {
            yield return new WaitForSeconds(1f);
            quit.Invoke();
            stop--;
        }
    }
}
    
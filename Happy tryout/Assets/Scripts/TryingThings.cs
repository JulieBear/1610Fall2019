using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TryingThings : MonoBehaviour
{
    public bool running = true;
    public int dex = 1;
    public UnityEvent damage;
    public float time = 1f;
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
        while(dex > 0)
        {
            yield return new WaitForSeconds(1f);
            damage.Invoke();
            dex--;
        }
        
    }
}
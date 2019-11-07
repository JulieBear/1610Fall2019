using System;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SPlayer"))
        {
            Destroy(other.gameObject);
        }
    }
}

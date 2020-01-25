using System;
using UnityEngine;

public class AmmoDisa : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            Destroy((other.gameObject));
        }
    }
}

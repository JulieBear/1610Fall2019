using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullFab;
    public int maxBull = 3;
    private int bullCount;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }

        if (maxBull > 0)
        {
            bullCount = 0;
        }
    }

    void Shot()
    {
        Instantiate(bullFab, transform.position, transform.rotation);
    }
}
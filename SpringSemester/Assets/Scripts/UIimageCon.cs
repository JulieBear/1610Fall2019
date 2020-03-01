using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UIimageCon : MonoBehaviour
{

    private Image img;

    private void Awake()
    {
        img = GetComponent<Image>();
    }
    
    

}

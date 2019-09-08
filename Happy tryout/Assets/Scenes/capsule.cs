using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class capsule : MonoBehaviour 
{
	public float floatValue = 3.2f;
	public int intValue = 20;
	public string stringValue = "YOU";
	public UnityEvent Event;
	
	// Use this for initialization
	void Start () 
	{
		Invoke("explode", 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

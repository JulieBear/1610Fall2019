using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Variables : MonoBehaviour
{

	public float floatValue = 5.5f;
	public int intValue = 20;
	public string stringValue = "Bob";
	public int firePower;
	public UnityEvent Event;
	private void OnTriggerEnter(Collider other)
	{
		print("testing");
		Event.Invoke();
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}

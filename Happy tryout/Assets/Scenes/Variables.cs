using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.UIElements;

public class Variables : MonoBehaviour
{

	public float floatValue = 5.5f;
	public int intValue = 20;
	public string stringValue = "Bob";
	// public int firePower;
	public UnityEvent Event;

	private void Start()
	{
		print("What did I do????");
	}

	public void OnMouseExit()
	{
		print("Does this work?");
	}

	// This also causes issues for mousedown, have one or the other.
	//public void OnMouseDrag()
	//{
		//print("I'll test more besides messages once I see how they work.");
	//}

	// This gets in the way of mousedown, have one or the other.
	//private void OnMouseOver()
	//{
	//	print(message: "This ruins mouse down.");
	//}

	public void OnMouseDown()
	{
		print("hello");
	}

	// Because it is the let go of the click, both are still properly used.
	private void OnMouseUpAsButton()
	{
		print("Will this override mousedown as well? Nope.");
	}

	private void OnTriggerEnter(Collider other)
	{
		print("testing");
		Event.Invoke();
	}

	
}

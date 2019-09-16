using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MouseEvents : MonoBehaviour
{
	public UnityEvent mouseEvent;

	private void OnMouseDown()
	{
		mouseEvent.Invoke();
	}
	
	//This caused such interesting things to happen.
	//private void OnTriggerEnter(Collider other)
	//{
	//	mouseEvent.Invoke();
//	}
	
}

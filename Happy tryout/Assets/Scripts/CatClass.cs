// what would I do to turn a light back on?

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatClass : MonoBehaviour
{
	public UnityEvent mewMew;

	private void OnMouseDown()
	{
		mewMew.Invoke();
		print("mew");
	}

	
		private void OnTriggerEnter(Collider other)
		{
			mewMew.Invoke();
		}
		
		private void OnMouseUpAsButton()
		{
			print("Messages still work.");
		}
}

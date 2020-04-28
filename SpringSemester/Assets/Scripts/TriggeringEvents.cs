using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{

	public UnityEvent trigEve, trigExit, trigStart;
	
	private void OnTriggerEnter(Collider other)
	{
		trigEve.Invoke();
	}

	private void OnTriggerExit(Collider other)
	{
		trigExit.Invoke();
	}
}

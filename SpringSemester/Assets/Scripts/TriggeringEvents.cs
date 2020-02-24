using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour {
	
	public UnityEvent trigEve;

	private void OnTriggerEnter(Collider other)
	{
		trigEve.Invoke();
	}
}

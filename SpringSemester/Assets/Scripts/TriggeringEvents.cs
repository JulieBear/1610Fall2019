using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour {

	public int trigInt = 3;
	public float trigFlo = 2;
	public string trigStri;
	public UnityEvent trigEve;

	private void OnTriggerEnter(Collider other)
	{
		trigEve.Invoke();
	}
}

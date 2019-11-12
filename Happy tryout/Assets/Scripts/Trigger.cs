using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class Trigger : MonoBehaviour
{
	private void Awake()
	{
		GetComponent<Collider>().isTrigger = true;
	}

	public UnityEvent EvTest;
	
	
	private void OnTriggerStay(Collider other)
	{
		print("testing");
		EvTest.Invoke();
	}
}

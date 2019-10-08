using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{

	public UnityEvent EvTest;
	
	
	private void OnTriggerEnter(Collider other)
	{
		print("testing");
		EvTest.Invoke();
	}
}

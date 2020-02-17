using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroPB : MonoBehaviour
{

	public bool running = true;
	public int index = 3;
	public float seconds = 1f;
	public UnityEvent onTriggerEnter;

	private WaitForSeconds secondsObj;

	IEnumerator OnTriggerEnter(Collider other)
	{
		while (index > 0)
		{
			Debug.Log(index);
			index--;
			yield return new WaitForSeconds(1f);
			onTriggerEnter.Invoke();
		}	
	}
}

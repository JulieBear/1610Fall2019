using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroHealth : MonoBehaviour
{

	public int count = 5;
	public float secs = 5f;
	public float secsTwo = 1f;
	public string mess = "Time";
	public IntDataObj numData;

	public UnityEvent trigEnter, trigExit;

	IEnumerator OnTriggerEnter (Collider other)
	{
		while (count > 0)
		{
			trigEnter.Invoke();
			numData.value = count;
			yield return new WaitForSeconds(secs);
			count--;
		}
		
		yield return new WaitForSeconds(secsTwo);
		trigExit.Invoke();
	}
}

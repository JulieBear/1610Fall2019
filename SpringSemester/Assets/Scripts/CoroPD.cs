using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroPD : MonoBehaviour
{

	public int index = 5;
	public UnityEvent onTriggerEnter, onTriggerExit;
	public float secs = 1f;
	public bool getGoing;

	private WaitForSeconds secObj;

	public void Awake()
	{
		secObj = new WaitForSeconds(secs);
	}

	public void CallCoroutine()
	{
		StartCoroutine(OnTriggerEnter(null));
	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		onTriggerEnter.Invoke();
		
		while (index > 0)
		{
			Debug.Log(index);
			index--;
			yield return new WaitForSeconds(1f);
			onTriggerEnter.Invoke();
		}
	}
}

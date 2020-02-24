using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CorounDestroy : MonoBehaviour
{

	public int index = 5;
	public UnityEvent onTriggerEnter;
	public float seconds = 1f;

	private WaitForSeconds secObj;

	public void Awake()
	{
		secObj = new WaitForSeconds(seconds);
	}

	public void CallCoroutine()
	{
		StartCoroutine(OnTriggerEnter(null));
	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		onTriggerEnter.Invoke();
		
		if (other.CompareTag("PickUp"))
		{
			Destroy(other.gameObject);
		}
		
		while (index > 0)
		{
			Debug.Log(index);
			index--;
			yield return new WaitForSeconds(1f);
			onTriggerEnter.Invoke();
		}
	}
}

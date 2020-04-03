using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Corostop : MonoBehaviour
{

	public int number = 3;
	public UnityEvent onTriggerStay, onTriggerExit;
	public float seconds = 5f;
	public float stopSeconds = .5f;
	public bool startRun;

	private WaitForSeconds secondObj;


	private void OnTriggerExit(Collider other)
	{
		StopCoroutine(onTriggerExit);
	}

	private void StopCoroutine(UnityEvent methodName)
	{
		onTriggerExit.Invoke();
	}

	private void Awake()
	{
		secondObj=new WaitForSeconds(seconds);
	}

	public void CallCoroutine()
	{
		StartCoroutine(OnTriggerStay(null));
	}


	
	//public void StopCoroutine()
	//{
	//	StopCoroutine();
	//}

	IEnumerator OnTriggerStay(Collider other)
	{
		onTriggerStay.Invoke();
		while (number > 0)
		{
			number--;
			yield return new WaitForSeconds(seconds);
			onTriggerStay.Invoke();
		}
	}
	
	void Update () {
		
	}
}

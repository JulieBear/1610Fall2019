using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.WSA.Input;

public class Coroutines : MonoBehaviour
{
	public UnityEvent repeatEvent, startEvent, endEvent;
	public float seconds = .5f;
	public int counter = 3;
	public bool canRun;
	private WaitForSeconds wfsObj;

	private void Awake()
	{
		wfsObj = new WaitForSeconds(seconds);
	}

	public void CallCoroutine()
	{
		StartCoroutine(RunCoroutine());
	}

	IEnumerator RunCoroutine()
	{
		startEvent.Invoke();
		
		while (counter > 0)
		{
			repeatEvent.Invoke();
			yield return wfsObj;
			counter--;
		}

		while (canRun)
		{
			repeatEvent.Invoke();
			yield return wfsObj;
			counter--;
		}
		endEvent.Invoke();
	}
	
	
	
	
	//{
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log(3);
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log(2);
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log(1);
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log("Go");
	//}
}

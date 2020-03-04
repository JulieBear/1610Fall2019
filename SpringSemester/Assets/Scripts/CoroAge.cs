using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroAge : MonoBehaviour
{

	public int num = 3;
	public UnityEvent onTrigger, onTriggerE;
	public float secs = 5f;
	public float stopSecs = .5f;
	public bool canRun;

	private WaitForSeconds secObj;

	private void Awake()
	{
		secObj = new WaitForSeconds(secs);
	}
	
	public void CallCoroutine()
	{
		StartCoroutine(OnTriggerStay(null));
	}
	
	IEnumerator OnTriggerStay(Collider other)
	{
		onTrigger.Invoke();

		while (num > 0)
		{
			num--;
			yield return new WaitForSeconds(secs);
			onTrigger.Invoke();
		}

		while (canRun)
		{
			onTrigger.Invoke();
			yield return new WaitForSeconds(stopSecs);
			num--;
		}
	}

}

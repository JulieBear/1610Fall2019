using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroDestruction : MonoBehaviour
{
	public GameObject crystals;
	public int index = 3;
	public float secs = 1f;
	public UnityEvent endEvent;
	private WaitForSeconds crystalObj;

	private void Awake()
	{
		crystalObj = new WaitForSeconds(secs);
	}

	public void CallCoroutine()
	{
		StartCoroutine(RunCoroutine());
	}
	IEnumerator RunCoroutine ()
	{
		while (index > 0)
		{
			Debug.Log(index);
			index--;
			yield return new WaitForSeconds(1f);
		}
		//if (Destroy(StopCoroutine(endEvent)))
		{
			endEvent.Invoke();
		}
	}
}
	


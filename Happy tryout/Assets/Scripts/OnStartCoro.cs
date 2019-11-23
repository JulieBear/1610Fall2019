using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnStartCoro : MonoBehaviour
{
	public UnityEvent starEvent;
	public float secs = 1f;
	public int counts = 3;
	public bool runs;
	private WaitForSeconds wsObj;
	
	void Start () 
	{
		wsObj = new WaitForSeconds(secs);
	}

	public void CallingCoro()
	{
		StartCoroutine(routine: RunCoroutine());
	}

	IEnumerator RunCoroutine()
	{
		starEvent.Invoke();

		while (counts > 0)
		{
			yield return wsObj;
			counts--;
		}
	}
	

	
}

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroRe : MonoBehaviour
{

	public UnityEvent waitHere, andAgain, thatsIt;
	public float seconds = 1f;
	public int counter = 3;
	public bool beginRunin;
	private WaitForSeconds wsObj;

	private void Awake()
	{
		wsObj = new WaitForSeconds(seconds);
	}

	public void CallCourtine()
	{
		StartCoroutine(RunCorou());
	}

	IEnumerator RunCorou()
	{
		waitHere.Invoke();

		while (counter > 0)
		{
			andAgain.Invoke();
			yield return wsObj;
			counter--;
		}

		while (beginRunin)
		{
			andAgain.Invoke();
			yield return wsObj;
			counter--;
		}
		thatsIt.Invoke();
	}
}

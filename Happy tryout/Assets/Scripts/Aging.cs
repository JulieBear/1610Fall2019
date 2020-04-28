using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Aging : MonoBehaviour
{
	public float seconds = 5f;
	private WaitForSeconds waitObj;
	public bool canRun = true;
	public UnityEvent repeatEvent;

	private void Awake()
	{
		waitObj = new WaitForSeconds(seconds);
	}

	public void Restart()
	{
		
		StartCoroutine(OnStartCoroutine());
	}

	public IEnumerator OnStartCoroutine()
	{
		canRun = true;
		while (canRun)
		{
			repeatEvent.Invoke();
			yield return waitObj;
		}
	}
}

//onto the player 
//put player on trigger behavior 
//simpcoro - restart the coro 
//health in canrun -change value

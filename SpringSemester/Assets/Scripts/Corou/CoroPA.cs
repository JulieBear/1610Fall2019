using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroPA : MonoBehaviour
{

	public UnityEvent eventAgain, startEvent, finishEvent;
	public float seconds = 1f;
	public int count = 3;
	public bool startRun;
	private WaitForSeconds wsObject;

	void Awake () {
		wsObject = new WaitForSeconds(seconds);
	}

	public void GetCoroutine()
	{
		StartCoroutine(RunCoroutine());
	}

	IEnumerator RunCoroutine()
	{
		Debug.Log(count);

		while (count > 0)
		{
			eventAgain.Invoke();
			yield return wsObject;
			count--;
		}

		while (startRun)
		{
			eventAgain.Invoke();
			yield return wsObject;
			count--;
		}
		finishEvent.Invoke();
	}
	
}

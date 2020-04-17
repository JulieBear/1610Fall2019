using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Aging : MonoBehaviour
{
	private WaitForFixedUpdate waitObj;
	public int counter = 3;
	public float seconds = 1f;
	public IntDataObj numData;
	public bool canRun = true;

	public UnityEvent ontrigEnt;

	private void Awake()
	{
		waitObj = new WaitForFixedUpdate();
	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		while (canRun)
		{
			yield return waitObj;
			ontrigEnt.Invoke();
		}
	}
}

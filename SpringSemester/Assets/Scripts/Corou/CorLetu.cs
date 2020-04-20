using System;
using UnityEngine;

public class CorLetu : MonoBehaviour
{

	public float secs = 1f;
	public IntDataObj numData;
	public float stopSecs = .5f;
	public bool canRun;
	private WaitForSeconds secObj;

	private void OnTriggerEnter(Collider other)
	{
		secObj = new WaitForSeconds(secs);
	}

	private void OnTriggerExit(Collider other)
	{
		secObj = new WaitForSeconds(stopSecs);
	}

	void Update () {
		
	}
}

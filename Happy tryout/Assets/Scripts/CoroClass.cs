using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroClass : MonoBehaviour

{
	public bool canRun = true;
	public int index = 4;
	public float seconds = 1f;
	public UnityEvent test;

	private WaitForSeconds wfsObj2;
		//public ParticleSystem partPart;


		IEnumerator OnTriggerEnter(Collider other)
		{
		while (index > 0)
		{
			Debug.Log(index);
			index--;
			yield return new WaitForSeconds(1f);
			//partPart.Emit(20);
			test.Invoke();
		}
	}
	
	
	
	
	
	//public void Run()
	//{
	//	StartCoroutine(OnRun());
	//}


	//IEnumerator onmoused
	//{
	//	while (canRun)
	//	{
	//		yield return new WaitForSeconds(1f);
			
	//	}
	//}
}

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Damage : MonoBehaviour
{
	public bool running = true;
	public int dex = 4;
	public UnityEvent damage;
	public float time = 3f;
	private WaitForSeconds secsObj;

	private void Start()
	{
		secsObj = new WaitForSeconds(time);
	}

	//public void OnTriggerStay(Collider other)
	//{
	//	damage.Invoke();
	//}

	IEnumerator OnTriggerStay(Collider other)
	{
		while(dex > 0)
		{
			yield return new WaitForSeconds(1f);
			damage.Invoke();
		}
	}
}

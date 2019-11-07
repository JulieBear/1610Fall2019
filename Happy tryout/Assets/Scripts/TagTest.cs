using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TagTest : MonoBehaviour
{

	public UnityEvent partycle;
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			partycle.Invoke();
		}
	}
}

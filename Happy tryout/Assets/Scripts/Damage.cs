using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Damage : MonoBehaviour
{
	public UnityEvent damage;
	
	public void OnTriggerEnter(Collider other)
	{
		damage.Invoke();
	}
}

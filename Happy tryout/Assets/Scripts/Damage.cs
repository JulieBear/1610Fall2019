using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Damage : MonoBehaviour
{
	public UnityEvent damage;
	
	public void OnTriggerStay(Collider other)
	{
		damage.Invoke();
	}
}

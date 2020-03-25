using System;
using UnityEngine;
using UnityEngine.Events;

public class Collide : MonoBehaviour
{

	public UnityEvent collide;

	public void OnCollisionEnter(Collision other)
	{
		collide.Invoke();
		
	}
}

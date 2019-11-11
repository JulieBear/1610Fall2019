using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TagTest : MonoBehaviour
{

	
	public UnityEvent test;
	public ParticleSystem particles;

	private void OnTriggerEnter(Collider other)
	{
		test.Invoke();
	}
}

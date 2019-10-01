using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticleControl : MonoBehaviour
{

	public UnityEvent test;
	public ParticleSystem particles;
	
	//private void OnMouseEnter()
	//{
	//	particles.Emit(100);
	//}

	private void OnTriggerEnter(Collider other)
	{
		test.Invoke();
		particles.Emit(100);
	}
	
	
}

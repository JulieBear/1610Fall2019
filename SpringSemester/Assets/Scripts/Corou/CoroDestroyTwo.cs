using System;
using System.Collections;
using UnityEngine;

public class CoroDestroyTwo : MonoBehaviour {
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("crystalStop"))
		{
			Destroy(other.gameObject);
		}
	}

	IEnumerator destroyHoldEffect(GameObject particles)
	{
		yield return new WaitForSeconds(0.5f);
		if (particles)
		{
			particles.GetComponent<ParticleSystem>().loop = false;
		}
		yield return new WaitForSeconds(1);
		if (particles)
		{
			Destroy(particles);
		}
	}
	
	
	//IEnumerator destroyHoldEffect(GameObject)
	//{
	//	yield return new WaitForSeconds(0.5f);
	//	if (gameObject)
	//	{
			
	//	}
	//}
}

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CorouAgeTwo : MonoBehaviour
{

	public int count = 5;
	public float secon = 1f;
	public IntDataObj numData;

	public UnityEvent ageUp, ageStop;

	IEnumerator OnTriggerEnter(Collider other)
	{

		while (count > 0)
		{
			yield return new WaitForSeconds(secon);
			ageUp.Invoke();
			count--;
		}
		
		yield return new WaitForSeconds(secon);
		ageStop.Invoke();
	}
	
}

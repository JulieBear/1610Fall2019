using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CorouAgeTwo1 : MonoBehaviour
{

	public int couer = 3;
	public float onds = 1f;
	public string mess = "try";
	public IntDataObj numDat;

	public UnityEvent onTrigEnt, onTrigEx;

	IEnumerator OnTriggerEnter(Collider other)
	{
		onTrigEnt.Invoke();
		while (couer>0)
		{
			numDat.value = couer;
			yield return new WaitForSeconds(onds);
			couer--;
		}
	}

	IEnumerator OnTriggerExit(Collider other)
	{
		onTrigEx.Invoke();

		while (couer > 0)
		{
			numDat.value = couer;
			yield return new WaitForSeconds(onds);
			couer--;
		}
	}
}

using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class Trigger : MonoBehaviour
{
	private void Awake()
	{
		GetComponent<Collider>().isTrigger = true;
	}

	public UnityEvent EvTest;
	
	
	private void OnTriggerEnter(Collider other)
	{
		EvTest.Invoke();
	}
}

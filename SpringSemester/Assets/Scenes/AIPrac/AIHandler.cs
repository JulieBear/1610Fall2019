using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIHandler : MonoBehaviour
{

	private Vector3 currDestination;
	private NavMeshAgent theAgent;
	private Vector3 starting;
	public Transform destinObj;
	
	void Start ()
	{
		starting = transform.position;
		currDestination = starting;
		theAgent = GetComponent<NavMeshAgent>();
	}

	private void OnTriggerEnter(Collider other)
	{
		currDestination = destinObj.position;
	}
	
	//--return back to locations - starting = assign.

	private void OnTriggerExit(Collider other)
	{
		currDestination = starting;
	}

	private void Update()
	{
		theAgent.destination = currDestination;
	}
}

//update takes them back from current destination.

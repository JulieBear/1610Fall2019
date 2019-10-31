using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentHandler : MonoBehaviour
{
	private Transform currentDestination;
	private NavMeshAgent agent;
	private GameObject startObj;
	public Transform destinationObj;
	
	
	void Start ()
	{
		startObj = new GameObject();
		startObj.transform.position = transform.position;
		currentDestination = transform;
		agent = GetComponent<NavMeshAgent>();
	}

	private void OnTriggerEnter(Collider other)
	{
		currentDestination = destinationObj;
	}

	private void OnTriggerExit(Collider other)
	{
		currentDestination = startObj.transform;
	}

	void Update ()
	{
		agent.destination = destinationObj.position;
	}
}

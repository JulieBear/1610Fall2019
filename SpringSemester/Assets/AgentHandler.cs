using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentHandler : MonoBehaviour
{
	private Vector3 currDestin;
	private NavMeshAgent spy;
	private Vector3 startPoint;
	public Transform destinObj;
	
	void Start ()
	{
		startPoint = transform.position;
		currDestin = startPoint;
		spy = GetComponent<NavMeshAgent>();
	}

	private void OnTriggerEnter(Collider other)
	{
		currDestin = startPoint;
	}


	void Update ()
	{
		spy.destination = currDestin;
	}
}

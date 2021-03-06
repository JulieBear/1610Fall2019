﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgeBehav : MonoBehaviour
{

	private NavMeshAgent agent;
	//public Vector3 location;
	public Transform player;
	public float speed = 5f;
	private Transform currDestination;
	private int i;
	private bool canHunt;

	public List<Transform> patrolPoints;

	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		agent.speed = speed;
		currDestination = transform;
	}

	private void OnTriggerEnter(Collider other)
	{
		canHunt = true;
		currDestination = player;
	}

	private void OnTriggerExit(Collider other)
	{
		canHunt = false;
		currDestination = transform;
	}

	void Update ()
	{
		if (canHunt)
		{
			agent.destination = currDestination.position;
			return;
		}
		
		if (!agent.pathPending && agent.remainingDistance < 0.5f)
		{
			agent.destination = patrolPoints[i].position;
			i = (i + 1) % patrolPoints.Count;
		}
	}
}

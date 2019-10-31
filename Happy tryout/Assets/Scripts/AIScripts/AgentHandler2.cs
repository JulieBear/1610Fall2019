using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentHandler2 : MonoBehaviour
{
    private Vector3 currentDestin;
    private NavMeshAgent agent;
    private Vector3 startPoint;
    public Transform destinationObj;
	
	
    void Start ()
    {
        startPoint = transform.position;
        currentDestin = startPoint;
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        currentDestin = destinationObj.position;
    }

    //--return back to locations
    private void OnTriggerExit(Collider other)
    {
        currentDestin = startPoint;
    }

    void Update ()
    {
        agent.destination = currentDestin;
    }
}
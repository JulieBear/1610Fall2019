using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIHand : MonoBehaviour
{

	private Vector3 currentDestination;
	private NavMeshAgent thisAgent;
	private Vector3 onStart;
	public Transform destinationObj;

	void Start ()
	{
		onStart = transform.position;
		//destinationObj = onStart;
		thisAgent = GetComponent<NavMeshAgent>();
	}
	
	
	
	
	
	void Update ()
	{
		thisAgent.destination = currentDestination;
	}
}

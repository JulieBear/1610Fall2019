using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgeBehav : MonoBehaviour
{

	private NavMeshAgent agent;
	//public Vector3 location;
	public Transform player;
	public float speed = 5f;

	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		agent.speed = speed;
	}
	
	
	void Update ()
	{
		agent.destination = player.position;
	}
}

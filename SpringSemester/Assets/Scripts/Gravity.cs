
using UnityEngine;

public class Gravity : MonoBehaviour
{

	public float grav = 3f;
	private Vector3 move;

	void Start()
	{

	}


	void Update()
	{
		move.y = grav;
	}
}
using UnityEngine;

public class Gravity : MonoBehaviour
{
	public float gravity = 3f;
	private Vector3 moves;


	void Update ()
	{
		moves.y -= gravity;
	}
}

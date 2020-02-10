using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyForce : MonoBehaviour
{
	private Rigidbody riggyObj;
	public float force = 100;

	private Vector3 forceVector;

	private void Start()
	{
		riggyObj = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter(Collision other)
	{
		forceVector.y = force;
		riggyObj.AddForce(forceVector);
	}
}

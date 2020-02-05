using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
	public CharacterController controller;
	public Vector3 positi;
	public float speed = 10f, jumpForce = 20f;
	public float grav = 3f;
	public int maxJump = 2;

	private int jumpCount;
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	
	void Update ()
	{
		positi.x = speed * Input.GetAxis("Horizontal");
		positi.y -= grav;
		controller.Move(positi*Time.deltaTime);

		if (controller.isGrounded)
		{
			positi.y = 0;
			jumpCount = 0;
		}

		if (Input.GetButtonDown("jump") && jumpCount < maxJump)
		{
			jumpCount++;
			positi.y = jumpForce;
		}
	}
}

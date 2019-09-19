using UnityEngine;

public class Movement : MonoBehaviour
{

	public float speed = 1f;
	public float gravity = -3f;
	public float jumpSpeed = 100f;
	
	private Vector3 position;
	public CharacterController controller;
	void Update () 
	{
		//transform.Translate(position*Time.deltaTime);
		position.x = speed * Input.GetAxis("Horizontal");
		position.z = speed * Input.GetAxis("Vertical");
		//position.y += gravity;

		// -- Runner
		// position.x = speed;

		if (!controller.isGrounded)
		{
			position.y += gravity;
		}
		else
		{
			position.y = 0f;
		}
		
		if (Input.GetButtonDown("Jump"))
		{
			position.y = jumpSpeed;
		}
		
		controller.Move(position*Time.deltaTime);

		// -- Don't know what this does, but it looked cool.
		//Input.GetButton("Submit");
		
		
	}
}

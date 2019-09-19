using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementTwo : MonoBehaviour
{
	public CharacterController controller;
	public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
	private int jumpCount;
	public int jumpCountMax = 2;
	private Vector3 position;
	
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	void Update ()
	{
		position.x = moveSpeed*Input.GetAxis("Vertical");
		position.z = moveSpeed * Input.GetAxis("Horizontal");
		position.y -= gravity;

		if (controller.isGrounded)
		{
			position.y = 0;
			jumpCount = 0;
		}
		
		if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
		{
			position.y = jumpSpeed;
			jumpCount++;
		}
		
		controller.Move(position*Time.deltaTime);
	}
}

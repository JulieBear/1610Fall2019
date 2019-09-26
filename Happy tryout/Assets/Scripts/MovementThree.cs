using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class MovementThree : MonoBehaviour
{
	public UnityEvent eve;
	public CharacterController control;
	public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
	public int jumpCountMax = 2;
	private Vector3 pose;
	private int jumpCount;

	
	void Start ()
	{
		control = GetComponent<CharacterController>();
	}


	void Update()
	{
		pose.x = moveSpeed * Input.GetAxis("Horizontal");
		pose.y -= gravity;

		if (control.isGrounded)
		{
			pose.y = 0;
			jumpCount = 0;
		}

		if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
		{
			pose.y = jumpSpeed;
			jumpCount++;
		}
		

		control.Move(pose * Time.deltaTime);
	}
}

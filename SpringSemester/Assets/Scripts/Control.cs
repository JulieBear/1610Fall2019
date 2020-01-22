using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class Control : MonoBehaviour
{

	public UnityEvent events;
	public CharacterController conTroll;
	public float moveTime = 10f, jumpSpe = 20f;
	public float gravity = 3f;
	public int jumpMax = 2;
	public static double spedUp;
	private Vector3 posit;
	private int jumpCou;
	
	
	void Start ()
	{
		conTroll = GetComponent<CharacterController>();
	}
	

	void Update ()
	{
		posit.x = moveTime * Input.GetAxis("Horizontal");
		posit.y -= gravity;

		if (conTroll.isGrounded)
		{
			posit.y = 0;
			jumpCou = 0;
		}

		if (Input.GetButtonDown("Jump") && jumpCou < jumpMax)
		{
			jumpCou++;
			posit.y = jumpSpe;
		}

		conTroll.Move(posit * Time.deltaTime);
	}

}

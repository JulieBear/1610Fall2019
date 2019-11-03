using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedup : MonoBehaviour
{

	private float doSpeedUp = (float) 2.0;
	

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("SPlayer"))
		{
			MovementThree moveScript = other.gameObject.GetComponent<MovementThree>();
		}

		//if (MovementThree)
		{
			MovementThree.doSpeedUp = 1.5;
			MovementThree.StopSpeedUp();
		}
		Destroy(gameObject);
	}

	void StopSpeedUp()
	{
	//	WaitForSeconds (2.5f);
		doSpeedUp = (float) 2.0;
	}

	private float move = Input.GetAxis("Horizontal") * doSpeedup;
	private static float doSpeedup;
}

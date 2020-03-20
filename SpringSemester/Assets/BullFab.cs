using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullFab : MonoBehaviour
{
	public float speed = 15f;
	public Rigidbody2D rigidBod;
	
	void Start ()
	{
		rigidBod.velocity = transform.right * speed;
	}

	private void OnTriggerEnter2D(Collider2D hitInfo)
	{
		Debug.Log(hitInfo.name);
		Destroy(gameObject);
	}
}

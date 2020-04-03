using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroPCU : MonoBehaviour
{
	public UnityEvent stopCoroutine;
	public float smooth = 7f;

	public static Vector3 Target
	{
		get { return toward; }
		set
		{
			toward = value;
			
			print(message:"Move");
			print("toward");
		}
	}

	private static Vector3 toward;

	IEnumerator Move(Vector3 toward)
	{
		while (Vector3.Distance(transform.position, b: toward) > 0.05f)
		{
			transform.position = Vector3.Lerp(transform.position, toward, smooth * Time.deltaTime);
			yield return null;
		}
	}
}

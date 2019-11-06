using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvents1 : MonoBehaviour
{
	private Camera cam;
	public Vector3Data data;
	

	private void Start()
	{
		cam = Camera.main;
	}

	private void OnMouseDown()
	{
		var ray = cam.ScreenPointToRay(Input.mousePosition);
		var hit = ray.GetPoint(10);
		data.value = hit;
		Debug.Log(hit);
	}
}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CliSetPose : MonoBehaviour
{

	public CoroPCU coroScript;
	private void OnMouseDown()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		Physics.Raycast(ray, out hit);
		if (hit.collider.gameObject == gameObject)
		{
			Vector3 newTarget = hit.point + new Vector3(0, 0.5f, 0);
			CoroPCU.Target = newTarget;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CameraController))]
public class CameraController : MonoBehaviour
{
	private CameraController conCam;
	
	void Start ()
	{
		conCam = GetComponent<CameraController>();
	}
}

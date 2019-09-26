using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfState : MonoBehaviour
{
	public int a = 5;
	public int b = 5;
	public int c = 9;
	public string password = "YOYO12";
	public bool lightsOn = false;
	
	void Start ()
	{
		if (a+b != c)
		{
			print("true");
		}
		else
		{
			print("false");
		}

		if (password != "OU812")
		{
			print("true");
		}

		if (!lightsOn)
		{
			print("true");
		}

	}
	
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfFruit : MonoBehaviour
{
	public bool appleIsRipe, orangeIsRipe, peachIsRipe;
	
	void Start () 
	{
		if (appleIsRipe)
		{
			print("Pick the apple.");
		}
		else if (orangeIsRipe)
		{
			print("Pick the orange");
		}
		else if (peachIsRipe)
		{
			print("Pick the Peach");
		}
		else
		{
			print("Nothing is ripe.");
		}
	}
	
	
}

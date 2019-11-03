using System;
using UnityEngine;
using UnityEngine.Events;

public class EnumPowerUp : MonoBehaviour 
{

	public enum States
	{
		Sprint,
		Walk
	}

	public States currState;

	public UnityEvent normalPace, powerPace;
void Update ()
	{
		switch (currState)
		{
			case States.Sprint:
				break;
			case States.Walk:
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
		
	}
}

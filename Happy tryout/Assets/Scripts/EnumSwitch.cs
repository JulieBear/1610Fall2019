using System;
using UnityEngine;
using UnityEngine.Events;

public class EnumSwitch : MonoBehaviour 
{
	public enum States
	{
		Short,
		Tall,
	}

	public States currentState;

	public UnityEvent Ontriggerstay, Ontriggerexit;

	void Update () 
	{
		switch (currentState)
		{
			case States.Short:
				Ontriggerstay.Invoke();
				Debug.Log("test");
				break;
			case States.Tall:
				Ontriggerexit.Invoke();
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}

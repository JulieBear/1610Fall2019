using System;
using UnityEngine;

public class Enummy : MonoBehaviour {

	public enum GameStates
	{
		Starting,
		Playing,
		InStore,
		Pausing,
		Ending
	}

	public GameStates currGameState;
	
	public enum PlayerStates
	{
		Idle,
		Walk,
		Run,
		Jump
	}

	public PlayerStates currPlayerstate;
	
	void Start () {
		
	}
	
	
	void Update () 
	{
		switch (currPlayerstate)
		{
			case PlayerStates.Idle:
				print("I am idling.");
				break;
			case PlayerStates.Walk:
				break;
			case PlayerStates.Run:
				break;
			case PlayerStates.Jump:
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}

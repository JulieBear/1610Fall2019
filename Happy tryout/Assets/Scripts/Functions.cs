using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
	public string playerName;
	private int myNumber;
	public float speed = 5f;
	public GameObject player;
	public Color playerColor;
	void Start ()
	{
		ConfigGameObject();
	}

	private GameObject ConfigGameObject()
	{
		var newPlayer = Instantiate(player);
		newPlayer.layer = 0;
		newPlayer.active = true;
		newPlayer.tag = "Player";
		newPlayer.transform.position = Vector3.zero;
		newPlayer.name = playerName;
		newPlayer.GetComponent<Renderer>().material.color = playerColor;
		
		return newPlayer;
	}

	private string WelcomePlayer()
	{
		//Add player to database;
		return playerName + "Welcome to the game!";
	}

	private int AddNumbers(int a, int b)
	{
		print("a + b");
		return a + b;
	}

	private void OnTriggerEnter(Collider other)
	{
		speed = IncreaseSpeed(2f);
	}

	private float IncreaseSpeed(float multiplier)
	{
		return speed * multiplier;
	}
}

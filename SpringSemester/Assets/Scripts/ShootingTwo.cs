using System;
using UnityEngine;

public class ShootingTwo : MonoBehaviour
{

	public float bullSpeed = 100f;
	private Vector3 mouPosit, playerPosit;
	public GameObject bull;
	public GameObject player;


	private void Start()
	{
		playerPosit = GameObject.Find("Working").transform.position;
	}

	private void Update()
	{
		playerPosit = player.transform.position;
		
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(bull, playerPosit, Quaternion.identity);

			if (mouPosit.x > playerPosit.x)
			{
				transform.position += bullSpeed * Time.deltaTime * Vector3.right;

				if (mouPosit.x < playerPosit.x)
				{
					transform.position += bullSpeed * Time.deltaTime * Vector3.left;
				}

				mouPosit = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));

			}

		}
	}
}

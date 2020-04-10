using System;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{

	public float speed = 10;
	public int damage = 20;
	public Rigidbody2D ridgey;
	
	
	void Start ()
	{
		ridgey.velocity = transform.right * speed;
	}

	private void OnTriggerEnter(Collider other)
	{
		Ene enemy = other.GetComponent<Ene>();
		if (enemy != null)
		{
			enemy.Damaging(damage);
		}
		Destroy(gameObject);
	}
}

using System;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speedy = 20;
	public int dama = 40;
	public Rigidbody2D rigiy;
	void Start ()
	{
		rigiy.velocity = transform.right * speedy;
	}

	private void OnTriggerEnter2D(Collider2D hitInformation)
	{
		EnemyScr enemy = hitInformation.GetComponent<EnemyScr>();
		if (enemy != null)
		{
			enemy.AbsorbDamage(dama);
		}
		Destroy(gameObject);
		
	}
}

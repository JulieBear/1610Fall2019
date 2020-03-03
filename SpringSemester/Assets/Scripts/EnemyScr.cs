using System.Collections;
using UnityEngine;

public class EnemyScr : MonoBehaviour
{

	public int health = 100;
	public GameObject deathEff;

	public void AbsorbDamage(int damage)
	{
		health -= damage;
		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Instantiate(deathEff, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}

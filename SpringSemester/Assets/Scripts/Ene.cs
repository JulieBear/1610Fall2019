using System.Collections;
using UnityEngine;

public class Ene : MonoBehaviour
{

	public int heal = 50;

	public GameObject deathEff;

	public void Damaging(int damage)
	{
		heal -= damage;

		if (heal<=0)
		{
			Death();
		}
	}

	void Death()
	{
		Instantiate(deathEff, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}

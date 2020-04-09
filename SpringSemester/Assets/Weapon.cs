using UnityEngine;

public class Weapon : MonoBehaviour
{
//	public GameObject bulletPre;
	public Transform fireSpot;
	public int dama = 30;
	public GameObject imaEff;
	
	
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Shot();
		}
	}

	void Shot()
	{
		RaycastHit2D hitInformation = Physics2D.Raycast(fireSpot.position, fireSpot.right);

		if (hitInformation)
		{
			Ene enemy = hitInformation.transform.GetComponent<Ene>();
			if (enemy != null)
			{
				enemy.Damaging(dama);
			}

			Instantiate(imaEff, hitInformation.point, Quaternion.identity);
		}
	}
}

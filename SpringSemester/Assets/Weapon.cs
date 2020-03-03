using UnityEngine;

public class Weapon : MonoBehaviour
{
	public GameObject bulletPre;
	public Transform fireSpot;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Shot();
		}
	}

	void Shot()
	{
		Instantiate(bulletPre, fireSpot.position, fireSpot.rotation);
	}
}

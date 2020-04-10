using UnityEngine;

public class GunThree : MonoBehaviour
{

	public Transform firePoint;
	public GameObject bulletPre;
	public float maxBullets = 3;
	private int bullCount;

	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Shooting();
		}
	}

	void Shooting()
	{
		Instantiate(bulletPre, firePoint.position, firePoint.rotation);
	}
}

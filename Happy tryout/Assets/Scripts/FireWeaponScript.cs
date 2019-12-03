using UnityEngine;

public class FireWeaponScript : MonoBehaviour
{
	public GameObject ammo;
	void Update () 
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Instantiate(ammo,transform.position, Quaternion.identity);
		}
	}
}

using UnityEngine;

public class GunTwo : MonoBehaviour
{
	public Transform firingSpot;
	public GameObject bullFab;
	
	
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Shot();
		}
	}

	void Shot()
	{
		Instantiate(bullFab, firingSpot.position, firingSpot.rotation);
	}
}

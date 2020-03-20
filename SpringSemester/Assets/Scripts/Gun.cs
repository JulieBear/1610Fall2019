using UnityEngine;

public class Gun : MonoBehaviour
{

	public float damage = 5f;
	public float range = 30;
	
	
	void Update () {

		if (Input.GetButtonDown("Fire1"));
		{
			Shot();
		}
	}

	void Shot()
	{
		
	}
}

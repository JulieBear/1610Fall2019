using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

public class FlippingRe : MonoBehaviour
{
	public KeyCode key1 = KeyCode.LeftArrow, key2 = KeyCode.RightArrow;
	public float dir1 = 0, dir2 = 100;
	public VectorThreeD threeD;
	void Update () 
	{
		if (Input.GetKeyDown(key1))
		{
			transform.rotation = Quaternion.Euler(0,dir1,0);
			threeD.val.x = -1;
		}

		if (Input.GetKeyDown(key2))
		{
			transform.rotation = Quaternion.Euler(0,dir2,0);
			threeD.val.x = 1;
		}
	}
}

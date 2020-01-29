using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

public class FlippingRe : MonoBehaviour
{
	public VectorThreeD threeD;
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.rotation = Quaternion.Euler(0,180,0);
			threeD.val.x = -1;
		}

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.rotation = Quaternion.Euler(0,0,0);
			threeD.val.x = 1;
		}
	}
}

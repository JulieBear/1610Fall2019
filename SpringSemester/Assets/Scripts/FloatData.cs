using System;
using UnityEngine;

public class FloatData : MonoBehaviour
{

	public float minVal = 0;
	public float maxVal = 1;
	public float val = 1f;

	public void UpdateVal(float amount)
	{
		val += amount;
	}

	public void UpdateValRange(float amount)
	{
		if (val <= maxVal)
		{
			UpdateVal(amount);
		}
		else
		{
			val = maxVal;
		}

		if (val >= minVal)
		{
			UpdateVal(amount);
		}
		else
		{
			val = minVal;
		}
	}
	
	//comment made to teach myself: As I have rewritten what I have learned in 
	//class last semester, I've now understood why this script works and how
	//it works. The >< is the main part to this that makes it capable to do what it does
	//as well, the =. At first I thought this was complicated, but rewriting it makes
	//me see how simple it really was. NICE!
}

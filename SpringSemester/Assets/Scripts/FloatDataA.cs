using UnityEngine;

[CreateAssetMenu]
public class FloatDataA : ScriptableObject
{

	public float miniVal = 0;
	public float maxiVal = 1;
	public float value = 1f;

	public void ChangeValue(float number)
	{
		value += number;
	}
	
}

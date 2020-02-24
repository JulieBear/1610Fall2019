using UnityEngine;

[CreateAssetMenu]
public class FloatValue : ScriptableObject
{

	public float value = 1f;

	public void ChangeValue(float number)
	{
		value += number;
	}
}

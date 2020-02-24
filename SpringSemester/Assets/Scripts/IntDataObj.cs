using UnityEngine;

[CreateAssetMenu]
public class IntDataObj : ScriptableObject
{
	public int value = 1;

	public void ChangeValue(int number)
	{
		value += number;
	}
}

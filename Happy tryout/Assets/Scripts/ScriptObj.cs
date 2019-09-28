using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptObj : ScriptableObject
{
	
	public float value = 1f;

	public void UpdateValue(float amount)
	{
		value += amount;
	}

	public new string name;
	public string description;

	public int health;
	public int attackPower;
	public int luck;
	public int charm;
	public int navigationSkills;

}

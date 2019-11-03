using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu]
public class Debugger : ScriptableObject
{
	public void OnDebug(string words)
	{
		Debug.Log(words);
	}

	public void OnDebug()
	{
		Debug.Log(name);
	}
	
}

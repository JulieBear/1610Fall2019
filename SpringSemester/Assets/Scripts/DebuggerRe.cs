using UnityEngine;

[CreateAssetMenu]
public class DebuggerRe : ScriptableObject {

	public void TheDebugger(string info)
	{
		Debug.Log(info);
	}

	public void TheDebugger()
	{
		Debug.Log(name);
	}
}

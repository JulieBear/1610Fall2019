using System.Collections;
using UnityEngine;

public class CorouCl : MonoBehaviour
{
	private WaitForFixedUpdate waitObj;
	public bool canRun = true;
	
	void Start () {
		waitObj = new WaitForFixedUpdate();
	}

	public IEnumerator OnStartCorou()
	{
		while (canRun)
		{
			yield return waitObj;
			print("Repeating");
		}
	}
}

using System.Collections;
using UnityEngine;

public class CorouStopTwo : MonoBehaviour
{
	private WaitForFixedUpdate waitObject;
	public bool beginRun = true;	
	
	
	void Start () {
		waitObject=new WaitForFixedUpdate();
	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		while (beginRun)
		{
			yield return waitObject;
		}
	}
}

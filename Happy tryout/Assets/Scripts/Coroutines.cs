using System.Collections;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
	private int i = 3;
	private WaitForSeconds wfsObj = new WaitForSeconds(1f);
	
	IEnumerator Start()
	{
		while (i > 0)
		{
			yield return wfsObj;
			Debug.Log(i);
			i--;
		}
		yield return new WaitForSeconds(1f);
		Debug.Log("GO!");
	}
	
	
	
	
	//{
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log(3);
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log(2);
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log(1);
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log("Go");
	//}
}

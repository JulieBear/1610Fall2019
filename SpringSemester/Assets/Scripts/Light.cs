using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

[RequireComponent(typeof(Light))]
public class Light : MonoBehaviour
{
	private Light lightObj;

	void Start ()
	{
		lightObj = GetComponent<Light>();
		//lightObj.intensity = 0f;
	}
	
	
	void Update () {
		
	}
}

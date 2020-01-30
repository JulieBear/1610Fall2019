using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Starting : MonoBehaviour
{
	public string star;
	private UnityEvent stars;
	void Start ()
	{
		stars.Invoke();

	}
	
	
	
}

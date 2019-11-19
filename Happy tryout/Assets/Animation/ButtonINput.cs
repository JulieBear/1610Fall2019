using UnityEngine;
using UnityEngine.Events;

public class ButtonINput : MonoBehaviour
{

	public UnityEvent inputEvent;
	public string inputWord;
	
	void Update () 
	{
		if (Input.GetButtonDown(inputWord))
		{
			inputEvent.Invoke();
		}
	}
}

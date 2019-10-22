using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
	public UnityEvent startEvent;
	void Awake ()
	{
		startEvent.Invoke();
	}
	
}

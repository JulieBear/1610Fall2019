using UnityEngine;
using UnityEngine.Events;

public class Monobehaviours : MonoBehaviour
{
	public UnityEvent startEvent;

	void Start ()
	{
		startEvent.Invoke();
	}
}

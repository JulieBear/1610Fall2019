using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseEventsRe : MonoBehaviour
{

	public UnityEvent mouseEventRe;

	private void OnMouseDown()
	{
		mouseEventRe.Invoke();
	}
}

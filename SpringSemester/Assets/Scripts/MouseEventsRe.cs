using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseEventsRe : MonoBehaviour
{
	public UnityEvent mouseTwo;
	public UnityEvent mouseThree;
	public UnityEvent mouseFour;
	public UnityEvent mouseEventRe;

	private void OnMouseDown()
	{
		mouseEventRe.Invoke();
	}

	private void OnMouseDrag()
	{
		mouseThree.Invoke();
	}

	private void OnMouseEnter()
	{
		mouseFour.Invoke();
	}

	private void OnMouseExit()
	{
		mouseTwo.Invoke();
	}
}

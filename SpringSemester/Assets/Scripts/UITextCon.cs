using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextCon : MonoBehaviour
{

	private Text cornText;

	private void Awake()
	{
		cornText = GetComponent<Text>();
	}
	//public void UpdateText ()
}

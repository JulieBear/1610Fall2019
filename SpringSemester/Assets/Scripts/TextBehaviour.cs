using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
	private Text textObj;
	public IntDataObj dataObj;

	private void Start()
	{
		textObj = GetComponent<Text>();
	}

	private void Update()
	{
		textObj.text = dataObj.value.ToString();
	}
}

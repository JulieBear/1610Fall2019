using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class imageBehaviour : MonoBehaviour
{

	public Image img;
	public FloatValue dataObj;


	private void Start()
	{
		img = GetComponent<Image>();
	}

	private void Update()
	{
		img.fillAmount = dataObj.value;
	}
}

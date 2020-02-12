using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteController : MonoBehaviour
{
	public Color spriteColor = Color.green;
	public Color offColor = Color.red;
	private SpriteRenderer conSprite;

	void Start()
	{
		conSprite = GetComponent<SpriteRenderer>();
		conSprite.color = spriteColor;
	}

	private void OnEnable()
	{
		conSprite.color = spriteColor;
	}

	private void OnDisable()
	{
		conSprite.color = offColor;
	}
}

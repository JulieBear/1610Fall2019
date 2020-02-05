using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PlayerDataRe : GameStuffData
{

	public List<ArtData> art;

	public UnityAction<GameObject> instanceAction;
	public UnityEvent onStartEvent;

	public FloatData health;
	public EquipData equipment;
	public HeadgearData headMagic;
	public PowerData powerslvl;

	public void InstancePlayer()
	{
		var newPlayer = Instantiate(prefab);
		var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
		newSprite.sprite = spriteArt;
		newSprite.color = colorArt;
	}

	public void Start()
	{
		onStartEvent.Invoke();
	}
	
}

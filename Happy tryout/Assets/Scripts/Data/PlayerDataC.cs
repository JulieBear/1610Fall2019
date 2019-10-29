using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PlayerDataC : GameArtData
{
    public List<WeaponData> weapons;

    public UnityAction<GameObject> instanceAction;
    public UnityEvent onRunEvent;

    public FloatValue health;
    public ClothesData shirt;
    public ClothesData pants;
    public PowersData powerLvl;

    
    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
        //instanceAction(newPlayer);
        
    }

    public void Run()
    {
        onRunEvent.Invoke();
    }
}

using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerDataC : GameArtData
{
    public List<WeaponData> weapons;
    
    public FloatValue health;
    public ClothesData shirt;
    public ClothesData pants;
    
    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
    }
}

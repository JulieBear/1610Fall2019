using UnityEngine;

[CreateAssetMenu]
public class PlayerDataC : GameArtData
{
    public WeaponData weapon;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
    }
}

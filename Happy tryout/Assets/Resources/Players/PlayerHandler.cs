using UnityEngine;

[CreateAssetMenu]
public class PlayerHandler : ScriptableObject
{
	public PlayerDataC playerDataObj;

	public void SwitchPlayer(PlayerDataC data)
	{
		playerDataObj = data;
	}
	
	public void OnRub() 
	{
		playerDataObj.Run();
	}
}

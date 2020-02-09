using UnityEngine;

[CreateAssetMenu]
public class PlayerHand : MonoBehaviour
{

	public PlayerDataRe playDataObj;

	public void SwitchPlay(PlayerDataRe data)
	{
		playDataObj = data;
		
	}

	public void OnRun()
	{
		playDataObj.Start();
	}

}

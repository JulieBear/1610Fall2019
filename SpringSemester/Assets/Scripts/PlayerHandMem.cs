using UnityEngine;

//writing player handler again for memorization purposes.
public class PlayerHandMem : MonoBehaviour
{
	public PlayerDataRe plDataObj;

	public void PlaySwitch(PlayerDataRe dataRe)
	{
		plDataObj = dataRe;
	}

	public void onRun()
	{
		plDataObj.Start();
	}
}

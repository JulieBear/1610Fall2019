using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ArtCollect : MonoBehaviour
{

	public List<ArtGameData> collectionList;

	public void BringData(ArtGameData obj)
	{
		if (!collectionList.Contains(obj))
		{
			collectionList.Add(obj);
		}
	}

	public void DestroyLastObj()
	{
		if (collectionList.Contains(null))
		{
			collectionList.RemoveAt(collectionList.Count-1);
		}
	}

}

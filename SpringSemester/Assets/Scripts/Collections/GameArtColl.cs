using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class GameArtColl : ScriptableObject
{

	public List<ArtData> collList;

	public void AddData(ArtData obj)
	{
		if (!collList.Contains(obj))
		{
			collList.Add(obj);
		}
	}

	public void RemoveLastItem()
	{
		if (collList.Contains(null))
		{
			collList.RemoveAt(collList.Count-1);
		}
	}

}

using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
	public List<GameArtData> collectionList;

	public void AddData(GameArtData obj)

	{
		if (!collectionList.Contains(obj))
		{
			collectionList.Add(obj);
		}




		//foreach (var gameArt in collectionList)
		//{
		//	Debug.Log(gameArt);
		//}

		//--same as foreach
		//for (var i = 0; i < collectionList.Count; i++)
		//{
		//	Debug.Log(collectionList[i]);
		//}
	}

	public void RemoveLastItem()
	{

		if (collectionList.Contains(null))
		{
			collectionList.RemoveAt(collectionList.Count-1);
		}

	}










//	{
		//if (obj.collected)
		//{
		//	collectionList.Add(obj);
		//	obj.collected = true;
		//}
//	}
}

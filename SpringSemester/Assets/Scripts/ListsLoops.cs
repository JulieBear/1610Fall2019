using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ListsLoops : ScriptableObject
{

	public List<string> stringList;
	public string oneString;

	public void AddTolist(string stringObj)
	{
		stringList.Add(stringObj);
	}

	public void RemoveFromList(string stringObj)
	{
		for (int i = 0; i < stringList.Count; i++)
		{
			if (stringList[i] == stringObj)
			{
				stringList.Remove(stringObj);
			}
		}
	}

	public void SortList()
	{
		stringList.Sort();
	}

	public void CheckList()
	{
		foreach (var obj in stringList)
		{
			if (obj.Contains(oneString))
			{
				Debug.Log(obj);
			}
		}
	}
}

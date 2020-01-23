using UnityEngine;

public class NewClass : MonoBehaviour
{
	public string nameString;
	public int intNum = 3;
	public float floatNumb;
	public GameObject gameObj;
	
	void Start () 
	{
		print(nameString);
		print(intNum);
		print(floatNumb);
		print(gameObj);
	}
	
	void Update () 
	{
		
	}
}

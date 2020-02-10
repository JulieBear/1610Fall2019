using UnityEngine;

public class Ifstate : MonoBehaviour
{

	public int a = 10;
	public int b = 4;
	public int c = 14;
	public string password = "WellHello";
	public bool canRun = true;
	void Start () {
		if (a+b==c)
		{
			print("if true");
		}

		if (password != "WellHello")
		{
			print("That is correct!");
		}
		else
		{
			print("That is incorrect.");
		}

		if (canRun)
		{
			print("We can do it!");
		}
	}
	
	void Update () {
		
	}
}

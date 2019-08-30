using UnityEngine;

public class IfStatements : MonoBehaviour
{
	private float cocoaTemperature = 85.0f;
	private float hotlimitTemperature = 70.0f;
	private float coldlimitTemperature = 40.0f;
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();

		cocoaTemperature -= Time.deltaTime * 5f;
	}

	void TemperatureTest()
	{
		if (cocoaTemperature > hotlimitTemperature)
		{
			print("Cocoa is extremely hot.");
		}
		else if (cocoaTemperature < coldlimitTemperature)
		{
			print("Cocoa is chilly.");
		}
		else
		{
			print("Cocoa is perfect.");
		}
	}
}

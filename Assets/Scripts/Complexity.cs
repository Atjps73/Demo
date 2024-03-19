using UnityEngine;

public class Complexity : MonoBehaviour
{
	public void Increasing(ref float speed, float maxSpeed)
	{
		if (speed < maxSpeed)
		{
			speed += 0.00001f;
			Debug.Log(speed);
		}
	}
}

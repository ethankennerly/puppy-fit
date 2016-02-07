using UnityEngine;  // GameObject

public class ControllerUtil
{
	public static void SetStateArray(GameObject[] gameObjects, string[] states, bool isRestart = false)
	{
		for (int index = 0; index < gameObjects.Length; index++)
		{
			GameObject gameObject = gameObjects[index];
			string state = states[index];
			ViewUtil.SetState(gameObject, state, isRestart);
		}
	}
}

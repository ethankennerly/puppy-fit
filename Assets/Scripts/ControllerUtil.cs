using UnityEngine;  // GameObject
using System.Collections.Generic;  // Dictionary

public class ControllerUtil
{
	/**
	 * Side effect:  Clears news.
	 * TODO: Recurse.
	 */
	public static void SetStates(Dictionary<string, object> news, Dictionary <string, GameObject> sceneGraph)
	{
		foreach (KeyValuePair<string, object> item in news) {
			if (item.Value is string) {
				string state = (string) item.Value;
				GameObject gameObject = sceneGraph[item.Key];
				// Debug.Log("ControllerUtil.SetStates: " + gameObject + ": " + state);
				ViewUtil.SetState(gameObject, state, true); 
			}
		}
		news.Clear();
	}

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

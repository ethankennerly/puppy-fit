using UnityEngine;  // GameObject
using System.Collections.Generic;  // Dictionary

public class ControllerUtil
{
	/**
	 * @param	news	If key "state" in news, set descending child to that state.  Recurses news and descendents.  Side effect:  Clears all news.  
	 */
	public static void SetStates(Dictionary<string, object> news, Dictionary<string, GameObjectTree> descendents)
	{
		GameObjectTree tree;
		GameObject child;
		foreach (KeyValuePair<string, object> item in news) {
			tree = descendents[item.Key];
			child = tree.self;
			Dictionary<string, object> articles = (Dictionary<string, object>) item.Value;
			if (articles.ContainsKey("state")) {
				string state = (string) articles["state"];
				ViewUtil.SetState(child, state, true); 
				articles.Remove("state");
			}
			if (1 <= articles.Count) {
				SetStates(articles, tree.children);
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

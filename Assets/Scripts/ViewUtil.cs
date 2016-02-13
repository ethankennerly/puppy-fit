using UnityEngine;  // GameObject
using UnityEngine.UI;  // Text
using System.Collections.Generic;  // Dictionary

/**
 * Sharing code between projects:
 * Git repo or submodule.
 * Symlink on mac.
 * Copy code.
 * http://www.rivellomultimediaconsulting.com/symlinks-for-unity-game-development/
 */
public class ViewUtil
{
	/**
	 * Call animator.Play instead of animator.SetTrigger, in case the animator is in transition.
	 * Test case:  2015-11-15 Enter "SAT".  Type "RAT".  Expect R selected.  Got "R" resets to unselected.
	 * http://answers.unity3d.com/questions/801875/mecanim-trigger-getting-stuck-in-true-state.html
	 *
	 * Do not call until initialized.  Test case:  2015-11-15 Got warning "Animator has not been initialized"
	 * http://answers.unity3d.com/questions/878896/animator-has-not-been-initialized-1.html
	 *
	 * In editor, deleted and recreated animator state transition.  Test case:  2015-11-15 Got error "Transition '' in state 'selcted' uses parameter 'none' which is not compatible with condition type"
	 * http://answers.unity3d.com/questions/1070010/transition-x-in-state-y-uses-parameter-z-which-is.html
	 */
	public static void SetState(GameObject gameObject, string state, bool isRestart = true)
	{
		Animator animator = gameObject.GetComponent<Animator>();
		if (null != animator && animator.isInitialized)
		{
			// Debug.Log("ViewUtil.SetState: " + gameObject + ": " + state);
			if (isRestart)
			{
				animator.Play(state);
			}
			else
			{
				animator.Play(state, -1, 0f);
			}
		}
		else
		{
			Debug.Log("ViewUtil.SetState: Does animator exist? " + gameObject + ": " + state);
		}
	}

	public static void SetText(Text textComponent, string text)
	{
		textComponent.text = text;
	}

	/**
	 * Find the children game objects in the scene graph at the addresses from the view model's scene graph.
	 */
	public static Dictionary<string, GameObjectTree> FindGraph(Dictionary<string, object> graph, GameObject root)
	{
		Dictionary<string, GameObjectTree> sceneGraph = new Dictionary<string, GameObjectTree>();
		foreach (KeyValuePair<string, object> item in graph) {
			string address = item.Key;
			GameObject child = root.transform.Find(item.Key).gameObject;
			GameObjectTree node = new GameObjectTree(child);
			sceneGraph[item.Key] = node;
			if (null == child) {
				Debug.Log("Expected child at " + address);
			}
			else if (item.Value is Dictionary<string, object>) {
				Dictionary<string, object> subGraph = (Dictionary<string, object>) item.Value;
				sceneGraph[item.Key].children = FindGraph(subGraph, child);
			}
		}
		return sceneGraph;
	}
}

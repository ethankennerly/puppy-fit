using UnityEngine;
using System.Collections.Generic;

public class View
{
	public Controller controller;
	public Model model;
	public GameObject main;
	public Dictionary<string, GameObjectTree> graph;

	/**
	 * Add ButtonView component to buttons and waters.
	 * Expects collider on each cup.
	 * Test case:  2016-02-13 Mouse down on cup.  Expect log.  Got no response.
	 */
	public void Start()
	{
		if (null == main) {
			main = GameObject.Find("main");
			int index;
			string address;
			GameObject child;
			for (index = 0; index < waters.Length; index++) {
				address = "waters/cup_" + index;
				child = GameObject.Find(address);
				if (null == child) {
					Debug.Log("Expected child at " + address);
				}
				else {
					child.AddComponent<ButtonView>();
				}
			}
			for (index = 0; index < model.buttonCount; index++) {
				address = "button_" + index;
				child = GameObject.Find(address);
				child.AddComponent<ButtonView>();
			}
		}
	}
}

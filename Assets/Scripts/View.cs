using UnityEngine;
using System.Collections.Generic;

public class View
{
	public Model model;
	public GameObject main;
	public GameObject[] waters;
	public Dictionary<string, GameObjectTree> graph;
	
	public void Start()
	{
		if (null == main) {
			main = GameObject.Find("main");
			waters = new GameObject[model.water.count];
			for (int index = 0; index < waters.Length; index++) {
				string address = "waters/cup_" + index;
				GameObject child = GameObject.Find(address);
				if (null == child) {
					Debug.Log("Expected child at " + address);
				}
				waters[index] = child;
			}
		}
	}
}

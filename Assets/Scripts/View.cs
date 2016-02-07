using UnityEngine;

public class View
{
	public Model model;
	public GameObject main;
	public GameObject canvas;
	public GameObject playArea;
	public GameObject[] waters;
	
	public void Start()
	{
		if (null == main) {
			main = GameObject.Find("main");
			canvas = GameObject.Find("canvas");
			playArea = GameObject.Find("playArea");
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

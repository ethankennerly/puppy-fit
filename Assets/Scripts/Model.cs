using UnityEngine;  // Debug

public class Model
{
	public Water water = new Water();
	public ViewModel view = new ViewModel();

	public void Start()
	{
		water.Start();
	}

	public void OnMouseDown(string name)
	{
		Debug.Log("OnMouseDown: " + name);
		if ("button_0" == name) {
			view.graph["canvas"] = "closeOpen";
			view.graph["playArea"] = "drinkWater";
		}
		else if ("button_1" == name) {
			view.graph["canvas"] = "closeOpen";
			view.graph["playArea"] = "exercise";
		}
		else if ("button_2" == name) {
			view.graph["canvas"] = "closeOpen";
			view.graph["playArea"] = "eat";
		}
		else if ("button_3" == name) {
			view.graph["canvas"] = "closeOpen";
			view.graph["playArea"] = "sleep";
		}
		else if (name.IndexOf("cup") == 0) {
			water.ToggleNamed(name);
			view.graph["playArea"] = "drinkWater";
		}
	}
}

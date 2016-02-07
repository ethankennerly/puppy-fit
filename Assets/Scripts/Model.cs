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
		// Debug.Log("OnMouseDown: " + name);
		if ("button_0" == name) {
			view.news["canvas"] = "closeOpen";
			view.news["playArea"] = "drinkWater";
		}
		else if ("button_1" == name) {
			view.news["canvas"] = "closeOpen";
			view.news["playArea"] = "exercise";
		}
		else if ("button_2" == name) {
			view.news["canvas"] = "closeOpen";
			view.news["playArea"] = "eat";
		}
		else if ("button_3" == name) {
			view.news["canvas"] = "closeOpen";
			view.news["playArea"] = "sleep";
		}
		else if (name.IndexOf("cup") == 0) {
			water.ToggleNamed(name);
			view.news["playArea"] = "drinkWater";
		}
	}
}

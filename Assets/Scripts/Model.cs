using UnityEngine;  // Debug
using System.Collections.Generic;  // Dictionary

public class Model
{
	public Water water = new Water();
	public ViewModel view = new ViewModel();
	public int buttonCount = 4;

	public void Start()
	{
		water.Start();
	}

	public void OnMouseDown(string name)
	{
		Debug.Log("OnMouseDown: " + name);
		if ("button_0" == name) {
			view.news["canvas"] = "closeOpen";
			view.news["playArea"] = "drinkWater";
			// TODO:
			// view.news["camera"] = "waters";
			// view.news["canvas"] = "close";
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
			string state = water.ToggleNamed(name);
			view.SetState(new string[]{"playArea", "waters", name}, state); 
			view.SetState(new string[]{"playArea"}, "drinkWater"); 
			view.SetState(new string[]{"canvas"}, "closeOpen");
		}
	}
}

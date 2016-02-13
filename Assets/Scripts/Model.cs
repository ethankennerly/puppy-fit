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
			view.SetState(new string[]{"canvas"}, "closeOpen");
			view.SetState(new string[]{"playArea"}, "drinkWater");
			// TODO:
			// view.SetState(new string[]{"camera"}, "waters");
			// view.SetState(new string[]{"canvas"}, "close");
		}
		else if ("button_1" == name) {
			view.SetState(new string[]{"canvas"}, "closeOpen");
			view.SetState(new string[]{"playArea"}, "exercise");
		}
		else if ("button_2" == name) {
			view.SetState(new string[]{"canvas"}, "closeOpen");
			view.SetState(new string[]{"playArea"}, "eat");
		}
		else if ("button_3" == name) {
			view.SetState(new string[]{"canvas"}, "closeOpen");
			view.SetState(new string[]{"playArea"}, "sleep");
		}
		else if (name.IndexOf("cup") == 0) {
			string state = water.ToggleNamed(name);
			view.SetState(new string[]{"playArea", "waters", name}, state); 
			view.SetState(new string[]{"playArea"}, "drinkWater"); 
			view.SetState(new string[]{"canvas"}, "closeOpen");
		}
	}
}

using UnityEngine;  // Debug

public class Model
{
	public Water water = new Water();
	public ViewModel view = new ViewModel();
	public int buttonCount = 4;
	private string[] camera = new string[]{"camera"};
	private string[] canvas = new string[]{"canvas"};

	public void Start()
	{
		water.Start();
		view.SetState(camera, "none");
	}

	public void OnMouseDown(string name)
	{
		// Debug.Log("OnMouseDown: " + name);
		if ("button_0" == name) {
			view.SetState(camera, "waters");
			view.SetState(canvas, "close");
		}
		else if ("button_1" == name) {
			view.SetState(canvas, "closeOpen");
			view.SetState(new string[]{"playArea"}, "exercise");
		}
		else if ("button_2" == name) {
			view.SetState(canvas, "closeOpen");
			view.SetState(new string[]{"playArea"}, "eat");
		}
		else if ("button_3" == name) {
			view.SetState(canvas, "closeOpen");
			view.SetState(new string[]{"playArea"}, "sleep");
		}
		else if (name.IndexOf("cup") == 0) {
			string state = water.ToggleNamed(name);
			view.SetState(new string[]{"playArea", "waters", name}, state); 
			view.SetState(new string[]{"playArea"}, "drinkWater"); 
			view.SetState(canvas, "closeOpen");
			view.SetState(camera, "none");
		}
	}
}

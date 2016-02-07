using UnityEngine;  // Debug.Log

public class Controller
{
	public Model model = new Model();
	public View view = new View();

	public void Start()
	{
		model.Start();
		view.model = model;
		view.Start();
		view.graph = ViewUtil.FindGraph(model.view.graph, view.main);
	}

	public void Update()
	{
		ControllerUtil.SetStateArray(view.waters, model.water.states);
	}

	public void OnMouseDown(string name)
	{
		model.OnMouseDown(name);
		Debug.Log("OnMouseDown: " + name);
		if ("button_0" == name) {
			ViewUtil.SetState(view.graph["canvas"], "closeOpen");
			ViewUtil.SetState(view.graph["playArea"], "drinkWater");
		}
		else if ("button_1" == name) {
			ViewUtil.SetState(view.graph["canvas"], "closeOpen");
			ViewUtil.SetState(view.graph["playArea"], "exercise");
		}
		else if ("button_2" == name) {
			ViewUtil.SetState(view.graph["canvas"], "closeOpen");
			ViewUtil.SetState(view.graph["playArea"], "eat");
		}
		else if ("button_3" == name) {
			ViewUtil.SetState(view.graph["canvas"], "closeOpen");
			ViewUtil.SetState(view.graph["playArea"], "sleep");
		}
		else if (name.IndexOf("cup") == 0) {
			model.water.ToggleNamed(name);
			ViewUtil.SetState(view.graph["playArea"], "drinkWater");
		}
	}
}

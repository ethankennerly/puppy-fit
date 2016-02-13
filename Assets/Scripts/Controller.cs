using UnityEngine;  // Debug.Log

public class Controller
{
	public Model model = new Model();
	public View view = new View();

	public void Start()
	{
		ButtonView.controller = this;
		MouseView.controller = this;
		view.model = model;
		view.controller = this;
		model.Start();
		view.Start();
		view.graph = ViewUtil.FindGraph(model.view.graph, view.main);
	}

	public void Update()
	{
		ControllerUtil.SetStates(model.view.news, view.graph);
		// ControllerUtil.SetStateArray(view.waters, model.water.states);
	}

	public void OnMouseDown(string name)
	{
		model.OnMouseDown(name);
	}
}

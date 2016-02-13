public class Controller
{
	public Model model = new Model();
	public View view = new View();

	public void Start()
	{
		model.Start();
		view.graph = ControllerUtil.FindGraphByName(model.view.graph, model.view.main);
		ControllerUtil.SetupButtons(this, model.view.buttons);
	}

	public void Update()
	{
		ControllerUtil.SetStates(model.view.news, view.graph);
	}

	public void OnMouseDown(string name)
	{
		model.OnMouseDown(name);
	}
}

public class Model
{
	public Water water = new Water();
	public ViewModel view = new ViewModel();
	private string[] camera = new string[]{"camera"};
	private string[] canvas = new string[]{"canvas"};
	public bool isVerbose = false;

	public void Start()
	{
		water.Start();
	}

	private void SetState(string[] address, string state)
	{
		ControllerUtil.SetNews(view.news, address, state);
	}

	public void OnMouseDown(string name)
	{
		if (isVerbose) {
			Toolkit.Log("OnMouseDown: " + name);
		}
		if ("button_0" == name) {
			SetState(camera, "waters");
			SetState(canvas, "close");
		}
		else if ("button_1" == name) {
			SetState(canvas, "closeOpen");
			SetState(new string[]{"playArea"}, "exercise");
		}
		else if ("button_2" == name) {
			SetState(canvas, "closeOpen");
			SetState(new string[]{"playArea"}, "eat");
		}
		else if ("button_3" == name) {
			SetState(canvas, "closeOpen");
			SetState(new string[]{"playArea"}, "sleep");
		}
		else if (name.IndexOf("cup") == 0) {
			string state = water.ToggleNamed(name);
			SetState(new string[]{"playArea", "waters", name}, state); 
			SetState(new string[]{"playArea"}, "drinkWater"); 
			SetState(canvas, "closeOpen");
			SetState(camera, "none");
		}
	}
}

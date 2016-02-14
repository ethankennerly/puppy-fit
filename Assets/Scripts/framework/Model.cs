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
			SetState(camera, "none");
		}
		else if ("button_2" == name) {
			SetState(canvas, "closeOpen");
			SetState(new string[]{"playArea"}, "eat");
			SetState(camera, "none");
		}
		else if ("button_3" == name) {
			SetState(canvas, "closeOpen");
			SetState(new string[]{"playArea"}, "sleep");
			SetState(camera, "none");
		}
		else if (name.IndexOf("cup") == 0) {
			string state = water.ToggleNamed(name);
			string soundName;
			SetState(new string[]{"playArea", "waters", name}, state); 
			if ("empty" == state) {
				SetState(new string[]{"playArea"}, "drinkWater"); 
				SetState(camera, "none");
				soundName = "drinkWater";
			}
			else {
				soundName = "drinkWaterUndo";
			}
			SetState(canvas, "closeOpen");
			view.soundNews.Add(soundName);
		}
	}
}

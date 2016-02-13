using System.Collections.Generic;

public class ViewModel
{
	public string main = "main";

	public Dictionary<string, object> graph = new Dictionary<string, object>(){
		{"camera", null},
		{"canvas", null},
		{"playArea", new Dictionary<string, object>(){
			{"waters", new Dictionary<string, object>() {
				{"cup_0", null},
				{"cup_1", null},
				{"cup_2", null}
			}}
		}}
	};

	public string[] buttons = new string[]{
		"button_0",
		"button_1",
		"button_2",
		"button_3",
		"cup_0",
		"cup_1",
		"cup_2",
	};

	public Dictionary<string, object> news = new Dictionary<string, object>(){
	};
}

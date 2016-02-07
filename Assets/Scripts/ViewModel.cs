using System.Collections.Generic;

public class ViewModel
{
	public Dictionary<string, object> graph = new Dictionary<string, object>(){
		{"canvas", null},
		{"playArea", new Dictionary<string, object>(){
			{"waters", new Dictionary<string, object>() {
				{"cup_0", null},
				{"cup_1", null},
				{"cup_2", null}
			}}
		}}
	};

	public Dictionary<string, object> news = new Dictionary<string, object>(){
	};
}

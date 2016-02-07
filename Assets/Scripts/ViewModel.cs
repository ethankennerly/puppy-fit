using System.Collections.Generic;

public class ViewModel
{
	public Dictionary<string, object> graph = new Dictionary<string, object>(){
		{"main", new Dictionary<string, object>() {
			{"canvas", "none"},
			{"playArea", "none"}}
		},
	};
}

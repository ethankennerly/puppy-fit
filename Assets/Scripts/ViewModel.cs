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

	public Dictionary<string, object> buttons = new Dictionary<string, object>(){
		{"canvas", new Dictionary<string, object>(){
			{"Panel", new Dictionary<string, object>() {
				{"button_0", null},
				{"button_1", null},
				{"button_2", null},
				{"button_3", null}
			}}
		}},
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

	/**
	 * Conveniently construct nested hashes.
	 * If an ancestor is already in news then merge.
	 */
	public void SetState(string[] address, string state)
	{
		Dictionary<string, object> parent = news;
		for (int index = 0; index < address.Length; index++) {
			string name = address[index];
			if (!parent.ContainsKey(name)) {
				parent[name] = new Dictionary<string, object>();
			}
			parent = (Dictionary<string, object>) parent[name];
		}
		parent["state"] = state;
	}
}

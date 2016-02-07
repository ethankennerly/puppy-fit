public class Water
{
	public bool[] isFulls;
	public string[] states;
	public int count = 3;

	public void Start()
	{
		isFulls = new bool[count];
		states = new string[count];
		for (int index = 0; index < count; index++) {
			isFulls[index] = false;
			states[index] = "none";
		}
	}

	public void Toggle(int index)
	{
		isFulls[index] = !isFulls[index];
		states[index] = isFulls[index] ? "begin" : "end";
	}

	public void ToggleNamed(string name)
	{
		int index = Toolkit.ParseIndex(name);
		Toggle(index);
	}
}

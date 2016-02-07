public class Model
{
	public Water water = new Water();
	public string canvas;
	public string playArea;

	public void Start()
	{
		water.Start();
		canvas = "none";
		playArea = "none";
	}
}

namespace Geometry
{
	public class ColourfulPoint:Point
	{
		public PointColour Colour { get; set; }

		public ColourfulPoint(decimal x, decimal y, PointColour colour) : base(x, y)
		{
			Colour = colour;
		}
	}
}
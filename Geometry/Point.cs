namespace Geometry
{
    public class Point:IReflacatble
    {
        private decimal _x;
        private decimal _y;

        public decimal X() => _x;
        public decimal Y() => _y;

        public Point() : this(0, 0) { }

        public Point(decimal x, decimal y)
        {
            _x = x;
            _y = y;
        }

        public void ReflectX()
        {
            _x = -_x;
        }

        public void ReflectY()
        {
            _y = -_y;
        }
    }
}
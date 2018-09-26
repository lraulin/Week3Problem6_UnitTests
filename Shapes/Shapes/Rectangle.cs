namespace ShapesNS
{
    public class Rectangle
    {
        //The underscore is a "style guideline"
        //but has no effect on how this compiles or runs.
        private double _length;
        private double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public double Perimeter
        {
            get
            {
                return 0;   //This isn't correct
            }

        }

        public double Area
        {
            get
            {
                return 0;   //Neither is this
            }
        }
    }
}
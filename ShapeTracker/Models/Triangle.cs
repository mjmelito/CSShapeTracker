namespace ShapeTracker.Models
{
    public class Triangle
    {
        private int _side1;
        public int Side1
        {
            get { return _side1; }
        }
        private int _side2;
        public int Side2
        {
            get { return _side2; }
        }

        public Triangle(int length1, int length2)
        {
            _side1 = length1;
            _side2 = length2;
        }
    }
}

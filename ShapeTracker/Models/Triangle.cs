namespace ShapeTracker.Models
{
    public class Triangle
    {
        private int _side1;
        public int Side1
        {
            get { return _side1; }
            set { _side1 = value; }

        }
        private int _side2;
        public int Side2
        {
            get { return _side2; }
        }

        private int _side3;
        public int Side3
        {
            get { return _side3; }
        }

        public Triangle(int length1, int length2, int length3)
        {
            _side1 = length1;
            _side2 = length2;
            _side3 = length3;
        }
    }
}

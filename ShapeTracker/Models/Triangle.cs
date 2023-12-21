namespace ShapeTracker.Models
{
    public class Triangle
    {
        public int _side1;
        public int _side2;
        public int _side3;

        public Triangle(int length1, int length2, int length3)
        {
            _side1 = length1;
            _side2 = length2;
            _side3 = length3;
        }

        public int GetSide1()
        {
            return _side1;
        }

        public int GetSide2()
        {
            return _side2;
        }

        public int GetSide3()
        {
            return _side3;
        }
        
        public string CheckType()
        {
            if ((_side1 > (_side2 + _side3)) || (_side2 > (_side1 + _side3)) || (_side3 > (_side1 + _side2)))
            {
                return "not a triangle";
            }
            else if ((_side1 != _side2) && (_side1 != _side3) && (_side2 != _side3)) 
            {
                return "scalene triangle";
            }  
            else if ((_side1 == _side2) && (_side1 == _side3)) 
            {
                return "equilateral triangle";
            } 
            else 
            {
                return "isosceles triangle";
            }
        }
    }
}
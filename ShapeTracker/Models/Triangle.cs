
using System.Runtime.InteropServices;

namespace ShapeTracker.Models
{
    public class Triangle
    {
        public int Side1;
        public int Side2 = 4;
        public int Side3;

        public Triangle(int length1, int length2, int length3)
        {
            Side1 = length1;
            Side2 = length2;
            Side3 = length3;
        }
    }
}
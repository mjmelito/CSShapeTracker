namespace ShapeTracker.Models
{
    public class Square
    {
        public int Side1;
        public int Side2;
        public int Side3;
        public int Side4;

        public Square(int length1)
        {
            Side1 = length1;
            Side2 = length1;
            Side3 = length1;
            Side4 = length1;
        }
    }
}
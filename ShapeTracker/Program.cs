using System;
using ShapeTracker.Models;

namespace ShapeTracker
{
    class Program
    {
        static void Main()
        {
            Triangle testTriangle = new Triangle(3, 4, 5);
            Console.WriteLine(testTriangle.GetType());


            Console.WriteLine($"Side one of the triangle: {testTriangle.Side1}");
            Console.WriteLine($"Side two of the triangle: {testTriangle.Side2}");
            Console.WriteLine($"Side three of the triangle: {testTriangle.Side3}");
        }
    }
}
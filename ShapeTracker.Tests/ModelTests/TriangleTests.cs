using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {

    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(3, 4, 5);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3;
      int length2 = 4;
      int length3 = 5;
      Triangle newTriangle = new Triangle(length1, length2, length3);
      int result = newTriangle.Side1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      int length1 = 3;
      int length2 = 4;
      int length3 = 5;
      Triangle newTriangle = new Triangle(length1, length2, length3);
      int result = newTriangle.Side2;
      Assert.AreEqual(length2, result); 
    }

    [TestMethod]
    public void GetSide3_ReturnsSide3_Int()
    {
      int length1 = 3;
      int length2 = 4;
      int length3 = 5;
      Triangle newTriangle = new Triangle(length1, length2, length3);
      int result = newTriangle.Side3;
      Assert.AreEqual(length3, result); 
    }
  }
}
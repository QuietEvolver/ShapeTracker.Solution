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
      Triangle newTriangle = new Triangle(2, 3, 5); // passes a length param property value
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1, 2, 8);
      // Act (by calling a method or retreiving a property) ie. Side1
      int result = newTriangle.Side1;
      // Assert
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      // Arrange
      Triangle newTriangle = new Triangle(3, 3, 8);
      int newLength1 = 44;
      // Act
      newTriangle.Side1 = newLength1;
      // Assert
      Assert.AreEqual(newLength1, newTriangle.Side1);
    }

    // Side 2: testing for auto-implemented properties
    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      // Arrange
      int length2 = 3;
      Triangle newTriangle = new Triangle(2, length2, 8);
      // Act
      int result = newTriangle.Side2;
      // Assert
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      // Arrange
      Triangle newTriangle = new Triangle(3, 4, 8);
      int newLength2 = 6;
      // Act
      newTriangle.Side2 = newLength2;
      // Assert
      Assert.AreEqual(newLength2, newTriangle.Side2);
    }

    // Side 3: Accessing & Testing A Private Field through its Getter and Setter Methods

    [TestMethod]
    public void GetSide3_ReturnsSide3_Int()
    {
      // Arrange
      int length3 = 55;
      Triangle newTriangle = new Triangle(2, 3, length3);
      // Act
      int result = newTriangle.GetSide3();
      // Assert
      Assert.AreEqual(length3, result);
    }

    [TestMethod]
    public void SetSide3_SetsValueOfSide3_Void()
    {
      // Arrange
      Triangle newTriangle = new Triangle(3, 4, 8);
      int newLength3 = 6;
      // Act
      newTriangle.SetSide3(newLength3);
      // Assert
      Assert.AreEqual(newLength3, newTriangle.GetSide3());
    }
  }
}
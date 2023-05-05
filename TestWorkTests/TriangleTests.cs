using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace TestWork.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            try
            {
                Triangle triangle = new Triangle(1, 1, 3);
                Assert.Fail();
            }
            catch
            {

            }
        }

        [TestMethod()]
        public void TriangleTestZeroSide()
        {
            try
            {
                Triangle triangle = new Triangle(0, 1, 1);
                Assert.Fail();
            }
            catch
            {

            }
        }

        [TestMethod()]
        public void CalculateRightTriangleAreaTest()
        {
            try
            {
                Triangle triangle = new Triangle(3, 6, 6.71);
                decimal area = ((decimal)triangle.CalculateArea());
                Assert.AreEqual(area, 9.0m, 0.1m);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod()]
        public void CalculateTriangleAreaTest1()
        {
            try
            {
                Triangle triangle = new Triangle(3, 6, 6);
                decimal area = ((decimal)triangle.CalculateArea());
                Assert.AreEqual(area, 8.71m, 0.1m);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        
    }
}
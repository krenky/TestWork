using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestWork.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CircleTest()
        {
            try
            {
                Circle circle = new Circle(1, 2);
                Assert.Fail();
            }
            catch
            {

            }
        }

        [TestMethod()]
        public void CircleTest1()
        {
            try
            {
                Circle circle = new Circle(12.56637d, 2);
                
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void CalculateAreaTest()
        {
            try
            {
                Circle circle = new Circle(12.56637d, 2);
                decimal area = ((decimal)circle.CalculateArea());
                Assert.AreEqual(area, 12.5664m, 0.1m);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void CalculateAreaByUsingLengthTest()
        {
            try
            {
                Circle circle = new Circle(12.56637d, 2);
                decimal area = ((decimal)circle.CalculateAreaByUsingLength());
                Assert.AreEqual(area, 12.5664m, 0.1m);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void CalculateAreaByUsingRadiusTest()
        {
            try
            {
                Circle circle = new Circle(12.56637d, 2);
                decimal area = ((decimal)circle.CalculateAreaByUsingRadius());
                Assert.AreEqual(area, 12.5664m, 0.1m);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void CalculateAreaByUsingDiameterTest()
        {
            try
            {
                Circle circle = new Circle(12.56637d, 2);
                decimal area = ((decimal)circle.CalculateAreaByUsingDiameter());
                Assert.AreEqual(area, 12.5664m, 0.1m);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
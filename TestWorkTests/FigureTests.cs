using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestWork.Tests
{
    [TestClass()]
    public class FigureTests
    {
        public Figure figure { get; set; }
        [TestMethod()]
        public void CalculateAreaTest()
        {
            try
            {
                string[] figures = new string[] { "c", "t", "t", "c", "t", "c" };
                foreach (string f in figures)
                {
                    switch (f)
                    {
                        case "c":
                            {
                                figure = new Circle(12.56637d, 2);
                                decimal area = ((decimal)figure.CalculateArea());
                                Assert.AreEqual(area, 12.5664m, 0.1m);
                            }
                            break;
                        case "t":
                            {
                                figure = new Triangle(3, 6, 6.71);
                                decimal area = ((decimal)figure.CalculateArea());
                                Assert.AreEqual(area, 9.0m, 0.1m);
                            }
                            break;
                    }
                }
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
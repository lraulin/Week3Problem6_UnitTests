using ShapesNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Perimeter_Is_Correct()
        {
            // Arrange
            double length = 4;
            double width = 5;
            double expected = 18;
            Rectangle rectangle = new Rectangle(length, width);

            // Act

            // Assert
            double actual = rectangle.Perimeter;
            Assert.AreEqual(expected, actual, 0.001, "Perimeter incorrect");
        }

        [TestMethod]
        public void Area_Is_Correct()
        {
            // Arrange
            double length = 4;
            double width = 5;
            double expected = 20;
            Rectangle rectangle = new Rectangle(length, width);

            // Act

            // Assert
            double actual = rectangle.Area;
            Assert.AreEqual(expected, actual, 0.001, "Perimeter incorrect");
        }
    }
}

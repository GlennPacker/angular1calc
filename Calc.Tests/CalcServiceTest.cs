using Calc.Entities;
using Calc.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc.Tests
{
    [TestClass]
    public class CalcServiceTest
    {
        private CalcService sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new CalcService();
        }

        [TestMethod]
        public void Can_Add_Two_Numbers()
        {
            // Arrange
            // Act
            var answer = sut.Calculate("1+1");

            // Assert
            Assert.AreEqual("2", answer.Result);
        }

        [TestMethod]
        public void Can_Multiply_Two_Numbers()
        {
            // Arrange
            // Act
            var answer = sut.Calculate("1*1");

            // Assert
            Assert.AreEqual("1", answer.Result);
        }

        [TestMethod]
        public void Can_Divide_Two_Numbers()
        {
            // Arrange
            // Act
            var answer = sut.Calculate("10/2");

            // Assert
            Assert.AreEqual("5", answer.Result);
        }

        [TestMethod]
        public void Can_Subtract_Two_Numbers()
        {
            // Arrange
            // Act
            var answer = sut.Calculate("10-2");

            // Assert
            Assert.AreEqual("8", answer.Result);
        }
    }
}

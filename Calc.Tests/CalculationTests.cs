using System;
using Calc.Entities;
using Calc.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc.Tests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void GetNumber_Will_Get_Prefix_Number()
        {
            // Arrange
            var calculation = new Calculation("12a");
            
                // Act
            var result = calculation.GetFirstNumber();

            // Assert
            Assert.AreEqual(12, result);
        }


        [TestMethod]
        public void GetNumber_Will_Get_Prefix_Number_With_Decimal_Places()
        {
            // Arrange
            var calculation = new Calculation("12.1+");

            // Act
            var result = calculation.GetFirstNumber();

            // Assert
            Assert.AreEqual((decimal)12.1, result);
        }

        [TestMethod]
        public void GetNumber_Will_Thow_When_Prefix_Is_Not_A_Number()
        {
            // Arrange
            Exception expectedExcetpion = null;
            var calculation = new Calculation("a12");

            // Act
            try
            {
                var result = calculation.GetFirstNumber();
            }
            catch (FormatException ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);
        }


        [TestMethod]
        public void GetLastNumber_Will_Get_Prefix_Number()
        {
            // Arrange
            var calculation = new Calculation("12a34");

            // Act
            var result = calculation.GetLastNumber();

            // Assert
            Assert.AreEqual(34, result);
        }

        [TestMethod]
        public void GetLastNumber_Will_Thow_When_Suffix_Is_Not_A_Number()
        {
            // Arrange
            Exception expectedExcetpion = null;
            var calculation = new Calculation("12a");

            // Act
            try
            {
                var result = calculation.GetLastNumber();
            }
            catch (FormatException ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);
        }


        [TestMethod]
        public void GetSymbol_Will_Return_Expression()
        {
            // Arrange
            var calculation = new Calculation("12+34");

            // Act
            var result = calculation.GetExpression();

            // Assert
            Assert.AreEqual("+", result);
        }
    }
}

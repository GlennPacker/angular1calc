using Calc.Core;
using Calc.Entities;
using System;

namespace Calc.Services
{
    public class CalcService : ICalcService
    {
        public Answer Calculate(string sum)
        {
            var calculation = new Calculation(sum);
            var firstNumber = calculation.GetFirstNumber();
            var expression = calculation.GetExpression();
            var lastNumber = calculation.GetLastNumber();
            return GetResult(firstNumber, expression, lastNumber);
        }

        public Answer GetResult(decimal firstNumber, string expression, decimal lastNumber)
        {
            switch (expression)
            {
                case "+":
                    return new Answer(firstNumber + lastNumber);
                case "-":
                    return new Answer(firstNumber - lastNumber);
                case "*":
                    return new Answer(firstNumber * lastNumber);
                case "/":
                    return new Answer(firstNumber / lastNumber);
                default:
                    throw new FormatException("Incorrect Format");
            }
        }
    }
}

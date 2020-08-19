using System.Text.RegularExpressions;

namespace Calc.Entities
{
    public class Calculation
    {
        string Sum { get; set; }

        public Calculation() {}

        public Calculation(string sum) 
        {
            Sum = sum;
        }


        public decimal GetFirstNumber()
        {
            // var number = Regex.Match(Sum, @"^\d+").ToString();
            var number = Sum.Split(new string[] { GetExpression() }, System.StringSplitOptions.None);
            return FormatNumber(number[0]);
        }

        public decimal GetLastNumber()
        {
            //var sum = Regex.Replace(Sum, @"^\d+", "");
            // var number = Regex.Match(sum, @"\d+$", RegexOptions.RightToLeft).ToString();
            var number = Sum.Split(new string[] { GetExpression() }, System.StringSplitOptions.None);
            return FormatNumber(number[1]);
        }

        public string GetExpression()
        {
            // return Regex.Replace(Sum, @"[\d-]", string.Empty);
            return Regex.Replace(Sum, @"[\d|.]", string.Empty);

        }

        public decimal FormatNumber(string number)
        {
            if (number == "") throw new System.FormatException("Incorrect Format");
            return decimal.Parse(number);
        }
    }
}

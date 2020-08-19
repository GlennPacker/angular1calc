using Calc.Entities;

namespace Calc.Core
{
    public interface ICalcService
    {
        Answer Calculate(string sum);
    }
}
using Calc.Entities;

namespace Calc.Core
{
    public interface ILogRepository
    {
        void Add(Log log);
        void Save();
    }
}
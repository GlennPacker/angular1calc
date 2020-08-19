using Calc.Core;
using Calc.Entities;

namespace Calc.Services
{
    public class LogService : ILogService
    {
        private readonly ILogRepository _logRepository;

        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public void Add(Log log)
        {
            _logRepository.Add(log);
            _logRepository.Save();
        }
    }
}

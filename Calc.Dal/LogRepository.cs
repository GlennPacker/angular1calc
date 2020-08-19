using Calc.Core;
using Calc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Dal
{
    public class LogRepository : ILogRepository
    {
        private readonly CalcContext _db;

        public LogRepository(CalcContext db)
        {
            _db = db;
        }

        public void Add(Log log)
        {
            _db.Logs.Add(log);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

using Calc.Entities;
using System.Data.Entity;

namespace Calc.Core
{
    public class CalcContext : DbContext
    {
        public CalcContext() : base("dbConn")
        {
        }

        public DbSet<Log> Logs { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calc.Entities
{
    public class Log
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IPAddress { get; set; }
        public DateTime Created { get; set; }

        public Log(string ipAddress)
        {
            Created = DateTime.Now;
        }
    }
}

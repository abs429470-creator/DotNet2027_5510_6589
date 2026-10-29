using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Students
    {
        public int studentId { get; set; }
        public string? studentName { get; set; }
        public int testId { get; set; }
        public int mark { get; set; }

        public Students() { }
    }
}
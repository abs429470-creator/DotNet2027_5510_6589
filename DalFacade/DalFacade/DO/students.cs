using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Students
    (
        int studentId,
    string? studentName,
    int testId,
    int mark
    )
    {
        public Students() : this() { }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DO
{
    public record Test
    (
     int testId,
     testType testType,
     DateTime dateOfTest,
    int count
     
        )
    { public test() : this(0, testType.None, DateTime.Now, 0) { } }
}

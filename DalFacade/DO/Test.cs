using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace DO;
    
        public record Test
        (
            int testId ,
            testType testType ,
            DateTime dateOfTest ,
            int count
        )
        {   

            public Test() : this(0, 0, DateTime.Now, 0) { } 
}
    

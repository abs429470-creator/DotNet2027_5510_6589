using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace DO;
    
        public record Test
        {
            public int testId { get; set; }
            public testType testType { get; set; }
            public DateTime dateOfTest { get; set; }
            public int count { get; set; }

            public Test(){ }
        }
    

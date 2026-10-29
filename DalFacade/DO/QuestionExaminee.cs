using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record QuestionExaminee
    {
       public int questionExamineeId { get; set; }
        public int studentId { get; set; }
        public int testId { get; set; }
        public int questionId { get; set; }
        public int examineeAnswerId { get; set; }




        public QuestionExaminee()  { }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record QuestionExaminee
     (
        int studentId,
        int testId,
        int questionId ,
        int examineeAnswerId
     )
    {
        public QuestionExaminee() : this(0, 10, 1, 100 ) { }
    }
}
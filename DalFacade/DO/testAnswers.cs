using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record TestAnswers
     (
    int answerId ,
    int questionId ,
    string answerText
     )
    {
        public TestAnswers() : this(0, 0, string.Empty) { }
    }
}
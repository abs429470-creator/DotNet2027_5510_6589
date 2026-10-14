using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DO
{
 
    public record   question
    (
      int questionId,
      questionType  QuestionType,
      string? content,
      int isCorect)
    { public question (): this(0, questionType.None, null, 0 ) {} 
}
      
}

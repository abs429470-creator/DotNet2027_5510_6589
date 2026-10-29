using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DO;

 
    public record Question
    {
    public int questionId { get; set; }
    public questionType  questionType { get; set; }
    public string? content { get; set; }
    public int isCorect { get; set; }



    public Question() {} 

      
}

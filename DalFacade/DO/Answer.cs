using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Answer
    {
        public int answerId { get; set; }
        public int questionId { get; set; }
        public string? content { get; set; }
    
        public Answer() { }
    }
}
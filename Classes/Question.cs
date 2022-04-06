using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.WindowsForms
{
    public class Question
    {
        public string QuestionContent { get; set; }
        public List<string> Answers { get; set; }
    }
}

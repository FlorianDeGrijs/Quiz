using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    interface IQuiz
    {
        public int Difficulty { get; set; }
        public string Category { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public void ShowQuestion(int counter);
    }
}

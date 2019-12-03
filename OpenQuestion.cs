using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class OpenQuestion : IQuiz
    {
        public int Difficulty { get; set; }
        public string Category { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public void ShowQuestion(int counter)
        {
            Console.WriteLine($"\nQuestion {counter}: {Question}");
        }

        public override string ToString()
        {
            return "Category: " + Category + " ||| Difficulty: " + Difficulty;
        }
    }
}

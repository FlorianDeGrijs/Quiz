using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class MultipleChoiceQuestion : IQuiz
    {
        public int Difficulty { get; set; }
        public string Category { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public List<string> choices { get; set; }

        public void ShowQuestion(int counter)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nQuestion " + counter + ": " + Question + "\n");
            foreach (string choice in choices)
            {
                sb.Append(choice + "\n");
            }
            Console.WriteLine(sb.ToString());
        }

        public override string ToString()
        {
            return "Category: " + Category + " ||| Difficulty: " + Difficulty;
        }
    }
}
